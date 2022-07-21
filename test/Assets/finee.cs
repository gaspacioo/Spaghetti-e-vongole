using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finee : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
