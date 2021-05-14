using UnityEngine;

public class TimeManagerScript : MonoBehaviour
{
    public float isTime;

    public bool slowdownTime = false;



     void Update()
    {
        if (slowdownTime == true)
        {
            Time.timeScale -= 0.005f;
        }

        if (Time.timeScale <= 0.1)
        {
            Time.timeScale = 0;
            slowdownTime = false;
        }
    }

}
