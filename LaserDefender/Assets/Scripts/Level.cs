using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField]
    float delayInSeconds = 2f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>()?.ResetGame();
    }
    public void LoadGameOver()
    {
        StartCoroutine(WaitAndLoad());
    }

    private IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
