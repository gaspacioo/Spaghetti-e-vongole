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
    public GameObject milicchio;
    public GameObject milicchio2;
    public GameObject progetto;
    public GameObject consegna;

    void Update()
    {
        if (PlayerPrefs.GetInt("isPassed1") == 1)
        {
           
            gerryScotti.SetActive(false);
            sheldon.SetActive(true);
            

            if (PlayerPrefs.GetInt("isPassed2") == 1)
            {
               
                sheldon.SetActive(false);
                sheldon2.SetActive(true);
                //milicchio.SetActive(true);
                //progetto.SetActive(true);
                //consegna.SetActive(true);
            }
        }

       
    }
}

    
