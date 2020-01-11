using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
