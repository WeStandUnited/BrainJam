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
public void timedSceneSwap(){

  int time = 0;
  bool act = true;
  while (act){
    time++;

    if (time == 1000){

      act =false;
    }


  }

  SceneManager.LoadScene(1);



}

public void loadscene(){

  SceneManager.LoadScene(1);


}


public void levelSelectStarter(){
SelectLevel s = new SelectLevel();

  if ( s.getLevelnumber()== 1){

    SceneManager.LoadScene(1);



  }else {


  }




}


}
