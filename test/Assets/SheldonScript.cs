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
    private int isPassed2 = 0;


    public void sasso()
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
                if (punteggio >= 2)
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
                Debug.Log("Spock vaporizza il sasso");
                avversario.text = "Spock vaporizza il sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("Sasso uccide lizard");
                avversario.text = "Il sasso uccide lizard";
                testo.text = punteggio.ToString();
            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("la carta avvolge il sasso");
                avversario.text = "La carta avvolge il sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("same");
                avversario.text = "Sasso vs sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("sasso rompe le forbici");
                avversario.text = "Il sasso rompe le forbici";
                testo.text = punteggio.ToString();
            }
        }
    }

    public void carta()
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
                if (punteggio >= 2)
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
                Debug.Log("La carta invalida Spock");
                avversario.text = "La carta invalida Spock";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("Lizard mangia la carta");
                avversario.text = "Lizard mangia la carta";
                testo.text = punteggio.ToString();
            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("same");
                avversario.text = "Carta vs carta";
                testo.text = punteggio.ToString();
            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("La carta avvolge il sasso");
                avversario.text = "La carta avvolge il sasso";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                Debug.Log("Le forbici tagliano la carta");
                avversario.text = "Le forbici tagliano la carta";
                testo.text = punteggio.ToString();
            }
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
                if (punteggio >= 2)
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
                avversario.text = "Spock rompe le forbici";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Le forbici decapitano Lizard";
                testo.text = punteggio.ToString();

            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Le forbici tagliano la carta";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Il sasso rompe le forbici";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Forbici vs forbici";
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
                if (punteggio >= 2)
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
                avversario.text = "Lizard avvelena Spock";
                testo.text = punteggio.ToString();

            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Lizard vs lizard";
                testo.text = punteggio.ToString();
            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Lizard mangia la carta";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Il sasso uccide Lizard";
                testo.text = punteggio.ToString();
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Le forbici decapitano Lizard";
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
                if(punteggio >= 2)
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
                avversario.text = "Spock vs spock";
                testo.text = punteggio.ToString();
            }
        }

        if (b.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Lizard avvelena Spock";
                testo.text = punteggio.ToString();

            }
        }

        if (c.Equals(v[Random.Range(0, v.Length)]))
        {
            if (conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "La carta invalida Spock";
                testo.text = punteggio.ToString();

            }
        }

        if (d.Equals(v[Random.Range(0, v.Length)]))
        {
            if(conteggio > 3)
            {
                if (punteggio >= 2)
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
                avversario.text = "Spock vaporizza il sasso";
                testo.text = punteggio.ToString();
                
            }
        }

        if (e.Equals(v[Random.Range(0, v.Length)]))
        {
            if(conteggio > 3)
            {
                if(punteggio >= 2)
                {
                    isPassed2 = 1;
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
                avversario.text = "Spock rompe le forbici";
                testo.text = punteggio.ToString();
                
            }
        }
    }
    public void finito()
    {
        isPassed2 = 1;
       
       
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

    void Start()
    {
        
        isPassed2 = PlayerPrefs.GetInt("isPassed2");

    }
    void Update()
    {
        PlayerPrefs.SetInt("isPassed2", isPassed2);
    }
           
}

