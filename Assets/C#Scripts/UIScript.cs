using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject startCanvas;
    [SerializeField]
    private GameObject gameOverCanvas;
    [SerializeField]
    private GameObject canvasFinish;

 

    private void Start()
    {
        startCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        canvasFinish.SetActive(false);
    }

    public void crashCanvasSwitch()
    {
        if (gameOverCanvas.activeSelf == false)
        {
            gameOverCanvas.SetActive(true);
        }
    }

    public void finishCanvasSwitch()
    {
        if (canvasFinish.activeSelf == false)
        {
            canvasFinish.SetActive(true);
        }
    }

    public void startCanvasOff()
    {
        startCanvas.SetActive(false);
    }


    // Via Editor through Ui Buttons
    public void Restart()
    {
        Debug.Log("Restart");

        SceneManager.LoadScene("GameScene");
    }
}