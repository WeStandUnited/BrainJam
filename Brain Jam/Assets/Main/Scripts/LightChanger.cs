using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour {

    public Light Light;
	public Color color;
    public Color color2;
    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("KeyDown")) {
            Light.color = color;

        }
        if (Input.GetButtonDown("KeyUp"))
        {
            Light.color = color2;
        }
    }
}
