using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverCanvas;
    [SerializeField]
    private GameObject canvasFinish;


    private void Start()
    {
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


    // Via Editor through Ui Buttons
    public void Restart()
    {
        Debug.Log("Restart");

        SceneManager.LoadScene("GameScene");
    }
}