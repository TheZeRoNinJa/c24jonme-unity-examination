using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}
