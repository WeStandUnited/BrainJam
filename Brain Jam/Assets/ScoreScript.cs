using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour {


private static int score = 0;



public void addScore(){


  score++;
   Debug.Log(score);
}
public int getScore(){


  return score;
}

public void takeScore(){


  score--;
}

public void wipeScore(){


  score = 0;
}

}
