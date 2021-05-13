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

    public UIScript uiScript;

    // Game Over
    private void OnCollisionEnter(Collision collision)
    {
        colObjTag = collision.gameObject.tag;


        if (colObjTag == carTag)
        {
            Debug.Log($"Game Over!");

            timeScript.slowdownTime = true;

            uiScript.gameDelayedRestart();
        }
    }

    // Finish Line
    private void OnTriggerEnter(Collider other)
    {
        colObjTag = other.gameObject.tag;

        if (colObjTag == finishTag)
        {
            Debug.Log("Finish!!!");

            timeScript.slowdownTime = true;
        }
    }   
}
