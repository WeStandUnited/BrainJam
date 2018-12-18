using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreScript : MonoBehaviour {
  int num = 0;
	String scoreString ;
	public Text points;
	void Start()
     {

			   //Text sets your text to say this message
      points.text  = "0";
     }
	// Update is called once per frame
	void Update () {
		num = GameObject.Find("BreakFruit").GetComponent<BreakFruit>().getScore();
		scoreString = num.ToString();
		points.text  = scoreString;

	}
}
