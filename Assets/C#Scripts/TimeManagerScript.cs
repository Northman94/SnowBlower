using UnityEngine;

public class TimeManagerScript : MonoBehaviour
{
    public float isTime;

    public bool slowdownTime = false;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void PushTime()
    {
        Time.timeScale = 1;
    }

    //Lowing down time
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
