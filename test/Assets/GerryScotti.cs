using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerryScotti : MonoBehaviour
{
    public GameObject gerryScotti;
    public GameObject sheldon;
    public GameObject gerryScotti2;
    public GameObject sheldon2;

    void Start()
    {
        if (PlayerPrefs.GetInt("isPassed1") == 1)
        {
            gerryScotti.SetActive(false);
            sheldon.SetActive(true);
            gerryScotti2.SetActive(true);
        }
    }
}

    
