using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class CCount : MonoBehaviour
{

    private int Ccount;


    public Text countText;

    // Use this for initialization
    void Start()
    {
        Ccount = 0;


        countText.text = "Human Crashes:" + Ccount.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name.StartsWith("common"))
        {

            Ccount = Ccount + 1;
            countText.text = "Human Crashes: " + Ccount.ToString();


            StartCoroutine(Timer());

        }






    }

    IEnumerator Timer()
    {

        yield return new WaitForSeconds(4);

    }

}
