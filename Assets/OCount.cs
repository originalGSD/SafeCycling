using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class OCount : MonoBehaviour
{

    private int Ocount;


    public Text countText;

    // Use this for initialization
    void Start()
    {
        Ocount = 0;


        countText.text = "Obstacle Crashes: " + Ocount.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name.StartsWith("tree"))
        {
            
            Ocount = Ocount + 1;
            countText.text = "Obstacle Crashes: " + Ocount.ToString();
            StartCoroutine(Timer());

        }






    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);

    }

}
