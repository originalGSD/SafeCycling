using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
        {
            Vector3 newCameraPosition = transform.position + GameObject.FindGameObjectWithTag("MainCamera").transform.forward * 10 * Time.deltaTime;
           transform.position = new Vector3(newCameraPosition.x, transform.position.y, newCameraPosition.z);
        }
	}
}
