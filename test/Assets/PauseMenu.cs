using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    [SerializeField] RectTransform transizione;

    public void PauseButton()
    {
         if (GameIsPaused)
         {
            Resume();
         }
            else
         {
            Pause();
         }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    private void Start()
    {
        transizione.gameObject.SetActive(true);

        LeanTween.scale(transizione, new Vector3(1, 1, 1), 0);
        LeanTween.scale(transizione, Vector3.zero, 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete(() =>
        {
            transizione.gameObject.SetActive(false);
        });
    }
    public void LoadMenu()

    {
        Time.timeScale = 1f;
        transizione.gameObject.SetActive(true);
        pauseMenuUI.SetActive(false);

        LeanTween.scale(transizione, Vector3.zero, 0f);
        LeanTween.scale(transizione, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete(() =>
        {
            SceneManager.LoadScene("MainMenu");
        });
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}