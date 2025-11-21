using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoreButton()
    {
        SceneManager.LoadScene("LoreScene");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
