using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Bottoni : MonoBehaviour
{
    // Vettore delle domande
    public GameObject[] vettore = new GameObject[15];
    private int isPassed1 = 0;
    private float CFU1 = 0;

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
        if (domandeCont < domandeNum && cont < 30)
        {

            // Disattivo la domanda Attuale
            vettore[prec].SetActive(false);

            // Mi prendo un indice a caso e verifico che non sia uguale alla domanda appena fatta
            while (i == prec)
                i = Random.Range(0, vettore.Length);
            cont -= 3;

            // Attivo la domanda successiva domanda 
            vettore[i].SetActive(true);
            // Setto prec per ricordarmi l'indice della domanda appena fatta
            prec = i;
            
            domandeCont++;

            
            testo.text = cont.ToString();
        }

        else
        {
            if (cont < 18)
            {
                alert.SetActive(true);
                prec = 0;
                i = 0;
                domandeCont = 0;
                
                for(int i=1; i<vettore.Length; i++)
                {
                    vettore[i].SetActive(false);
                }
                Sbagliato();
                cont = 0;
                testo.text = cont.ToString();

            }

            else
            {
                if(cont >= 21)
                {
                    isPassed1 = 1;
                    CFU1 = cont - 3;
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                }
                else
                {
                    alert.SetActive(true);
                    prec = 0;
                    i = 0;
                    domandeCont = 0;

                    for (int i = 1; i < vettore.Length; i++)
                    {
                        vettore[i].SetActive(false);
                    }
                    Sbagliato();
                    cont = 0;
                    testo.text = cont.ToString();
                }
                

            }
        }
    }

    public void Avanti()
    {

        if (domandeCont < domandeNum && cont < 30) {

            // Disattivo la domanda Attuale
            vettore[prec].SetActive(false);

            // Mi prendo un indice a caso e verifico che non sia uguale alla domanda appena fatta
            while (i == prec)
                i = Random.Range(0, vettore.Length);
            cont += 6;

            // Attivo la domanda successiva domanda 
            vettore[i].SetActive(true);
            // Setto prec per ricordarmi l'indice della domanda appena fatta
            prec = i;
            
            domandeCont++;

            
            testo.text = cont.ToString();
        }

        else
        {
            if (cont < 18)
            {
                alert.SetActive(true);
                prec = 0;
                i = 0;
                domandeCont = 0;
                
                for(int i = 1; i < vettore.Length; i++)
                {
                    vettore[i].SetActive(false);
                }
                Avanti();
                cont = 0;
                testo.text = cont.ToString();
            }

            else {
                isPassed1 = 1;
                if(cont + 6 > 30)
                {
                    CFU1 = 30;
                }
                else
                {
                    CFU1 = cont + 6;
                }
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }

    }

    public void Chiudi()
    {
        alert.SetActive(false);
    }

    void Start()
    {
        CFU1 = PlayerPrefs.GetFloat("CFU1");
        isPassed1 = PlayerPrefs.GetInt("isPassed1");

    }
    void Update()
    {
        PlayerPrefs.SetFloat("CFU1", CFU1);
        PlayerPrefs.SetInt("isPassed1", isPassed1);
    }


}
