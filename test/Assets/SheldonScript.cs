using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class SheldonScript : MonoBehaviour
{
    private string[] v = { "Sasso", "Carta", "Forbici", "Lizard", "Spock" };
    private int conteggio = 0;
    private int i = 0;
    public Text testo;
    private int punteggio = 0;
    public GameObject sbagliato;
    public Text avversario;


    public void sasso()
    {
        string a = "Sasso";

        int i = Random.Range(0, v.Length);

        if (a.Equals(v[i]))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }

    public void carta()
    {
        string a = "Carta";

        int i = Random.Range(0, v.Length);

        if (a.Equals(v[i]))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }

    public void forbici()
    {
        string a = "Spock";
        string b = "Lizard";
        string c = "Carta";
        string d = "Sasso";
        string e = "Forbici";

        if (a.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Spock rompe le forbici");
                avversario.text = "Spock";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Le forbici decapitano Lizard");
                avversario.text = "Lizard";
                testo.text = punteggio.ToString();

            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Le forbici tagliano la carta");
                avversario.text = "Carta";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Il sasso rompe le forbici");
                avversario.text = "Sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Same");
                avversario.text = "Forbici";
                testo.text = punteggio.ToString();
            }
        }

    }

    public void lizard()
    {
        string a = "Spock";
        string b = "Lizard";
        string c = "Carta";
        string d = "Sasso";
        string e = "Forbici";

        if (a.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Lizard avvelena Spock");
                avversario.text = "Spock";
                testo.text = punteggio.ToString();

            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Same");
                avversario.text = "Lizard";
                testo.text = punteggio.ToString();
            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Lizard mangia la carta");
                avversario.text = "Carta";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Il sasso uccide Lizard");
                avversario.text = "Sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Le forbici decapitano Lizard");
                avversario.text = "Forbici";
                testo.text = punteggio.ToString();
            }
        }
    }

    public void spock()
    {
        string a = "Spock";
        string b = "Lizard";
        string c = "Carta";
        string d = "Sasso";
        string e = "Forbici";
        

        if (a.Equals(v[Random.Range(0, v.Length)]))
        {
            
            if(conteggio>3)
            {
                if(punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Same");
                avversario.text = "Spock";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("Lizard avvelena Spock");
                avversario.text = "Lizard";
                testo.text = punteggio.ToString();

            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                Debug.Log("La carta invalida Spock");
                avversario.text = "Carta";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if(conteggio > 3)
            {
                if (punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Spock vaporizza il sasso");
                avversario.text = "Sasso";
                testo.text = punteggio.ToString();
                
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if(conteggio > 3)
            {
                if(punteggio >= 3)
                {
                    finito();
                }
                else
                {
                    sbagliato.SetActive(true);
                }
            }
            else
            {
                conteggio++;
                punteggio++;
                Debug.Log("Spock rompe le forbici");
                avversario.text = "Forbici";
                testo.text = punteggio.ToString();
                
            }
        }
    }
    public void finito()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void hoSbagliato()
    {
        sbagliato.SetActive(false);
        punteggio = 0;
        conteggio = 0;
        testo.text = punteggio.ToString();
        avversario.text = "";
    }
}

