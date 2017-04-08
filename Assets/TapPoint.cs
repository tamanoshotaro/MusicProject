using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapPoint : MonoBehaviour {

	public static float timer;
	public static float[] timing;
	private int indexTiming;

	public static int perfect;
	public static int great;
	public static int good;
	public static int miss;



	//エフェクト関係…あとから設定予定
	public GameObject perfectEffect;
	public GameObject greatEffect;
	public GameObject goodEffect;
	public GameObject missEffect;


	// Use this for initialization
	void Start () {
		timing = new float[] { 1.454f, 2.524f, 5.343f, 7.654f, 10.643f, 14.543f, 15.352f, 18.432f };

		perfect = 0; great = 0; good = 0; miss = 0; indexTiming = 0; timer = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (IsBeat ())
			checkTiming ();

		//ノーツがタップボタンを通り過ぎた場合の処理…ではあるがデストロイではダメか？
		/*
		else if (timer - timing [indexTiming] >= 0.12f) {
			addMiss();
			indexTiming++;
			//Instantiate (missEffect, transform.position, transform.rotation);
		}*/

		timer += Time.deltaTime;
	}


	public bool IsBeat(){
		//このif文内の条件をボタンタップに変更
		if (Input.GetKeyDown (KeyCode.Space))
			return true;
		else
			return false;
	}


	public void checkTiming(){
		if (timer - timing [indexTiming] >= -0.10f && timer - timing [indexTiming] <= 0.10f) {
			addPerfect ();
			indexTiming++;
			Instantiate (perfectEffect, transform.position, transform.rotation);
		} else if (timer - timing [indexTiming] >= -0.12f && timer - timing [indexTiming] <= 0.12f) {
			addGreat ();
			indexTiming++;
			Instantiate (greatEffect, transform.position, transform.rotation);
		} else if (timer - timing [indexTiming] >= -0.14f && timer - timing [indexTiming] <= 0.14f) {
			addGood ();
			indexTiming++;
			Instantiate (goodEffect, transform.position, transform.rotation);
		} else if (timer - timing [indexTiming] >= -0.6f && timer - timing [indexTiming] <= 0.6f) {
			addMiss ();
			indexTiming++;
			Instantiate (missEffect, transform.position, transform.rotation);
		} else {}
	}



	public void addPerfect(){perfect++;}
	public void addGreat(){great++;}
	public void addGood(){good++;}
	public void addMiss(){miss++;}



}
