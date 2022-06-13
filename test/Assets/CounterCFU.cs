using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterCFU : MonoBehaviour
{
    public Text text;
    private float i = 0;
    private bool booleana = true;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("isPassed1") == 1)
        {
            i = PlayerPrefs.GetFloat("CFU1");
            text.text = i.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
