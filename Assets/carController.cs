using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour {

    public float moveSpeed = 0.1f;
    public Vector3 moveVector;

    private Dictionary<string, float> direction = new Dictionary<string, float>();

    // Use this for initialization
    void Start()
    {
        direction.Add("left", -90);
        direction.Add("right", 90);
        direction.Add("forward", 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveVector * moveSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "turn")
        {
            float dir = direction[other.gameObject.GetComponent<turn>().direction];
            transform.Rotate(0, 0, dir);
        }
    }
}
