using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TruckCollisionManagerScript : MonoBehaviour
{
    private string carTag = "CarInSnow";
    private string finishTag = "Finish";

    private string colObjTag = null;

    public TimeManagerScript timeScript;




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

            timeScript.slowdownTime = true;
        }


    }


    private void OnTriggerEnter(Collider other)
    {
        colObjTag = other.gameObject.tag;

        if (colObjTag == finishTag)
        {
            Debug.Log("Finish!!!2");

            timeScript.slowdownTime = true;
        }
    }   
}
