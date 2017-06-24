using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class ResultData : MonoBehaviour {

	public int result_point;
	public int result_combo;
	public int rank_point;
	public string ranking;

	public Text scoreText;
	public Text comboText;
	public Text rankText;

	int countTime = 0;

	// Use this for initialization
	void Start () {
		result_point = GameEnd.x;
		result_combo = GameEnd.y;

		rank_point = result_point + result_combo;

		if(rank_point >= 200){
			ranking = "A";
		}else if(rank_point >= 150){
			ranking = "B";
		}else if(rank_point >= 100){
			ranking = "C";
		}else if(rank_point < 100){
			ranking = "D";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (countTime == 0) {
			scoreText.text = result_point.ToString ();
			comboText.text = result_combo.ToString ();
			rankText.text = ranking;

			Debug.Log ("総合得点は" + result_point + "！　最大コンボ数は" + result_combo + "です！！");
			countTime++;
		}
	}
}
