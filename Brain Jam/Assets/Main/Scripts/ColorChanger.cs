using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public Color color;
    

    public void ColorSwapper()  
    {

        gameObject.GetComponent<Renderer>().material.color = color;
    }



}
