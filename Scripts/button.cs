using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject pause;
    public GameObject Options;
    public GameObject level;
    public GameObject StartPanel;
    public GameObject pauseButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        StartPanel.SetActive(true);
        pause.SetActive(false);
        // Time.timeScale = 0f;

    }
    public void PlayGame()
    {
        pauseButton.SetActive(true);
        StartPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    public void pauseGame()
    {
        pauseButton.SetActive(false);
        pause.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        pauseButton.SetActive(true);
        pause.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    public void RestartCurrentLevel()
    {
        pauseButton.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        pause.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    public void OptionsPanel()
    {
        StartPanel.SetActive(false);
        pause.SetActive(false);
        Options.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelPanel()
    {
        StartPanel.SetActive(false);
        level.SetActive(true);
    }
}
