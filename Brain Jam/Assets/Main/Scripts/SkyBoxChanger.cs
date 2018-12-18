using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChanger : MonoBehaviour {


    public Material skybox;
//RenderSettings.skybox.SetFloat("_Exposure",PUT FLOAT IN HERE);
   float temp  = 0.24F;

//HEY WE MAY NEED TO SWAP TO A DYNAMIC SKYBOX AT THIS POINT


    public void DarkMode (){


      RenderSettings.skybox.SetFloat("_Exposure",temp);


    }


    public void ThicknessChanger(){

      RenderSettings.skybox.SetFloat("_Atmosphere Thickness",temp);

    }

}
