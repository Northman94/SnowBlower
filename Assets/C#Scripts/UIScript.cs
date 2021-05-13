using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverCanvas;


    private void Start()
    {
        gameOverCanvas.SetActive(false);
    }


    public void gameDelayedRestart()
    {
        Debug.Log("Delay");
        StartCoroutine("Restart", 3f);
    }

    public void gameInstantRestart()
    {
        Debug.Log("Instant");
        StartCoroutine("Restart", 0f);
    }


    IEnumerator Restart(float restartTime)
    {
        Debug.Log("IEnumerator");

        yield return new WaitForSeconds(restartTime); //Count is the amount of time in seconds that you want to wait.

        SceneManager.LoadScene("GameScene");
        //And here goes your method of resetting the game...


        yield return null;
    }




}