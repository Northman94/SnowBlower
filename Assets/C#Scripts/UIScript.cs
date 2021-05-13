using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void gameRestart()
    {
        SceneManager.LoadScene("GameScene");
    }   
}