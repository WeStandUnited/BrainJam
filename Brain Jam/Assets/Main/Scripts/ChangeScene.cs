using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour {

  public void sceneSwap()
    {

        SceneManager.LoadScene(1);
      //SceneManager.LoadScene("maingame", LoadSceneMode.Additive);
    }
public void loadscene(){

  SceneManager.LoadSceneAsync(1);


}


}
