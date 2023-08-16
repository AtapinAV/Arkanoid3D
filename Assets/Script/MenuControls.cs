using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("ExitGame Game");
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
