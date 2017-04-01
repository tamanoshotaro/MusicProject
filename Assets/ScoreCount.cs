using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	public Text scoreText;
	private int score = 0;


	// Use this for initialization
	void Start () {
		scoreText.text = "Dcore: 0";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
