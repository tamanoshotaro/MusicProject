using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour {

	public GameObject gamedata;

	public static int x;
	public static int y;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		//曲終了→GameEnd→TapToResult→別シーン(ResultScene)へ移動←移動の際にデータを引き継ぐ
		//引き継ぐデータ：最大コンボ数・スコア・PaGrGoMiの数(現時点ではデータ計測していないのでとりあえず無し)
		//移動先(ResultScene)において最大コンボ数と総合点とそこから総合評価(A〜D)を出す
		//評価を出したら『もう一度プレイする』的なボタンも出るようにする(押すとプレイ画面初期状態へ戻る)

		GameManager gamedata = GetComponent<GameManager> ();

		x = gamedata._score;
		y = gamedata.maxCombo;

		Debug.Log ("score : " + x + "/ MaxCombo : " + y);
		//上記のデータを引き継ぎつつ別シーンへ移動させる

		SceneManager.LoadScene ("ResultScene");

	}




}
