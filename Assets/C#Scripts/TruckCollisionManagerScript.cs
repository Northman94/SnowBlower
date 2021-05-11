using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TruckCollisionManagerScript : MonoBehaviour
{
    private string carTag = "CarInSnow";
    private string finishTag = "Finish";

    private string colObjTag = null;

 


    void Start()
    {

    }


    void Update()
    {

    }



    private void OnCollisionEnter(Collision collision)
    {
        colObjTag = collision.gameObject.tag;


        if (colObjTag == carTag)
        {
            Debug.Log($"Game Over!");

            Time.timeScale = 0;
        }


        if (colObjTag == finishTag)
        {
            Debug.Log("Finish!!!");

            timeStoper();
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        colObjTag = other.gameObject.tag;

        if (colObjTag == finishTag)
        {
            Debug.Log("Finish!!!");

            timeStoper();
        }
    }


    float timeScale = 1;

    private void timeStoper()
    {
        while (Time.timeScale > 0)
        {
            timeScale -= 0.1f;

            Time.timeScale = timeScale;
        }
    }
    
}
