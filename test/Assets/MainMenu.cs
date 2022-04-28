using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [SerializeField] RectTransform transizione;

    private void Start()
    {
        transizione.gameObject.SetActive(true);

        LeanTween.scale(transizione, new Vector3(1, 1, 1), 0);
        LeanTween.scale(transizione, Vector3.zero, 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete (() =>
        {
            transizione.gameObject.SetActive(false);
        });
    }
    public void PlayGame () {
        transizione.gameObject.SetActive(true); 

        LeanTween.scale(transizione, Vector3.zero, 0f);
        LeanTween.scale(transizione, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeInOutExpo).setOnComplete(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        });
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
