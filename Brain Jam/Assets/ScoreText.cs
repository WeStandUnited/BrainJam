 ﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour {


	ScoreScript score = new ScoreScript();
//	ScoreScript score = obj.AddComponent<ScoreScript>();

	public Text textBox;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	if (score.getScore() != null){
		textBox.text = "Score: " + score.getScore();
	}else {
			textBox.text = "Score: "+ 0;

	}
	}
}
