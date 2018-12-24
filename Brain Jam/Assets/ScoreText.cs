using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreText : MonoBehaviour {

	ScoreScript score = new ScoreScript();

	public Text textBox;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		textBox.text = "Score: " + score.getScore();
	}
}
