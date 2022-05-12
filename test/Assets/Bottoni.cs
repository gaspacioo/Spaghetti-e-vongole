using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Bottoni : MonoBehaviour
{
    // Vettore delle domande
    public GameObject[] vettore = new GameObject[15];

    CalcoloMedia media = new CalcoloMedia();

    // alert
    public GameObject alert;

    // Contatore punteggio
    public Text testo;

    // Valore che registra l'indice della domanda fatta 
    int prec = 0;

    int i = 0;
    float cont = 0;
    int domandeCont = 0;
    int domandeNum = 6;

    public void Sbagliato()
    {
        if (domandeCont < domandeNum)
        {

            // Disattivo la domanda Attuale
            vettore[prec].SetActive(false);

            // Mi prendo un indice a caso e verifico che non sia uguale alla domanda appena fatta
            while (i == prec)
                i = Random.Range(0, vettore.Length);

            // Attivo la domanda successiva domanda 
            vettore[i].SetActive(true);
            // Setto prec per ricordarmi l'indice della domanda appena fatta
            prec = i;

            domandeCont++;

            cont -= domandeNum / 60;
            testo.text = cont.ToString();
        }

        else
        {
            if (cont < 18)
            {
                alert.SetActive(true);
                Sbagliato();
                int prec = 0;
                int i = 0;
                float cont = 0;
               
                
            }

            else
            {
                media.setValore(float.Parse(this.testo.text), 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }
        }
    }

    public void Avanti()
    {

        if (domandeCont < domandeNum) {

            // Disattivo la domanda Attuale
            vettore[prec].SetActive(false);

            // Mi prendo un indice a caso e verifico che non sia uguale alla domanda appena fatta
            while (i == prec)
                i = Random.Range(0, vettore.Length);

            // Attivo la domanda successiva domanda 
            vettore[i].SetActive(true);
            // Setto prec per ricordarmi l'indice della domanda appena fatta
            prec = i;

            domandeCont++;

            cont += domandeNum / 30;
            testo.text = cont.ToString();
        }

        else
        {
            if (cont < 18)
            {
                alert.SetActive(true);
                Avanti();
                int prec = 0;
                int i = 0;
                float cont = 0;
                
                
            }

            else {
                media.setValore(float.Parse(this.testo.text), 1);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }
        }

    }

    public void Chiudi()
    {
        alert.SetActive(false);
    }

    


}
