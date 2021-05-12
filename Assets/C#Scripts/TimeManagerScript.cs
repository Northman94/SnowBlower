using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManagerScript : MonoBehaviour
{
    public float isTime;

    public bool slowdownTime = false;




    private void Update()
    {
        if (slowdownTime == true)
        {
            Time.timeScale -= 0.02f;
        }
    }

}
