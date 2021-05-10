using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TruckCollisionManagerScript : MonoBehaviour
{
    private string carTag = "CarInSnow";

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
        }
    }
}
