using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SheldonScript : MonoBehaviour
{
    private string[] v = { "Sasso", "Carta", "Forbici", "Lizard", "Shpock"};
    public GameObject[] buttons;
    public GameObject alert;
    int cont = 30;
    CalcoloMedia media = new CalcoloMedia();

    public void vai()
    {
        string a = this.name;

        int i = Random.Range(0, buttons.Length);

        if (cont < 18)
        {
            cont = 30;
            alert.SetActive(true);
        }

        else if (a.Equals(v[i]))
        {
            media.setValore(cont, 2);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else cont--;

    }

    public void Chiudi()
    {
        alert.SetActive(false);
    }

}
