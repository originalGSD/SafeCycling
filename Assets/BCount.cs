using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class BCount : MonoBehaviour
{

    private int Bcount;


    public Text countText;

    // Use this for initialization
    void Start()
    {
        Bcount = 0;


        countText.text = "Building Crashes: " + Bcount.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name.StartsWith("building"))
        {
            
            Bcount = Bcount + 1;
            countText.text = "Building Crashes: " + Bcount.ToString();
            StartCoroutine(Timer());

        }


        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);

    }

}
