using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Media : MonoBehaviour

{
    // Vettore delle domande
    public GameObject[] vettore = new GameObject[15];

    // Contatore punteggio
    public Text testo;
    float cont = 0;
    float tot = 0;
    int numEsami = 0;

    public void SetTesto(float a)
    {
        numEsami++;
        tot = cont + a;
        cont = tot / numEsami;

        testo.text = cont.ToString();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
