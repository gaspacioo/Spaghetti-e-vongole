using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Analisi : MonoBehaviour
{
    public GameObject gerry;
    public GameObject sheldon;
    public GameObject milicchio;

    public GameObject gerry2;
    public GameObject sheldon2;
    public GameObject milicchio2;

    bool fine = false;
    public GameObject milicchiotext;
    public GameObject milicchioObj;
    public GameObject laureaALert;


    public void GerryB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SheldonB()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

   

    public void Chiudi()
    {
        if (fine == true)
        {
            milicchiotext.SetActive(false);
            milicchio.SetActive(false);

            gerry2.SetActive(true);
            sheldon2.SetActive(true);
            milicchio2.SetActive(true);
        }
       
    }

    public void preso()
    {
        fine = true;
        milicchioObj.SetActive(false);
    }

    public void Laurea()
    {
        laureaALert.SetActive(true);
    }

    public void Fine()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
}
