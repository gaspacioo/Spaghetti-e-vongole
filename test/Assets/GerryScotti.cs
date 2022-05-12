using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerryScotti : MonoBehaviour
{
    public GameObject gerryScotti;
    public GameObject sheldon;

    public void GerryB()
    {
        gerryScotti.SetActive(false);
        sheldon.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

    
