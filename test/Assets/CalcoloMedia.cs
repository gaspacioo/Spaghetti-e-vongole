using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CalcoloMedia : MonoBehaviour
{
    
    public Text text;
    
    public float getValore()
    {
        float a= float.Parse(this.text.text); 

        return a; 
       
    }
     public void setValore(float a,int b)
    {
        float totp = this.getValore();
        this.text.text = ((totp + a) / b).ToString();
    }
   
}
