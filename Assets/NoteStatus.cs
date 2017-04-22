using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteStatus : MonoBehaviour {

	//ノーツのステータス情報

	public float[,] notesdata = {
		//{レーン位置,tick数(perfectのタイミング？),何個目のノーツか)}
		//とりあえず思い付いたら後から他の要素も追加
		//レーン位置に関しては生成管理の方が良いのか？
		{219.5f,8.737627f,0f},
		{319.5f,9.850921f,1f},
		{419.5f,10.73707f,2f},
		{519.5f,11.68561f,3f},
		{619.5f,12.76384f,4f},
		{419.5f,13.82695f,5f},
	};
	//上記はあくまでテスト


	// Use this for initialization
	public void Start () {

	}


	
	// Update is called once per frame
	void Update () {
	}
}
