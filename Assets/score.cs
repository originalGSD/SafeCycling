using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    private int Ocount;


    public Text countText;

	// Use this for initialization
	void Start () {
        Ocount = 500;
        countText.text = "Score: " + Ocount.ToString();

        InvokeRepeating("Tick", 5, 5);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.name.StartsWith("tree"))        
            {
            Ocount = Ocount - 50;
            countText.text = "Score: " + Ocount.ToString();
            StartCoroutine(Timer());
        }

        if (col.gameObject.name.StartsWith("building"))
        {
            Ocount = Ocount - 100;
            countText.text = "Score: " + Ocount.ToString();
            StartCoroutine(Timer());
        }

        if (col.gameObject.name.StartsWith("car"))
        {
            Ocount = Ocount - 200;
            countText.text = "Score: " + Ocount.ToString();
            StartCoroutine(Timer());
        }





    }

    void Tick()
    {
        Ocount = Ocount+100;
        countText.text = "Score: " + Ocount.ToString();
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(4);


    }

}
