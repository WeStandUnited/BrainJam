using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMeshProScore : MonoBehaviour {

 public TMPro.TextMeshProUGUI Score_Text;
	ScoreScript score = new ScoreScript();

 void Update () {

 if (score.getScore() != null){
	 Score_Text.text = "Score: " + score.getScore();
 }else {
		 Score_Text.text = "Score: "+ 0;

 }
 }

}
