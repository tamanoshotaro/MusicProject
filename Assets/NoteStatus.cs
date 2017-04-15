using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteStatus : MonoBehaviour {

	//ノーツのステータス情報

	public float[,] notesdata;

	// Use this for initialization
	public void Start () {



		notesdata = new float[,]{
			//{レーン位置,tick数(perfectのタイミング？),tag}とかとりあえず思い付いたら後から他の要素も追加
			//レーン位置に関しては生成管理の方が良いのか？
			{219.5f,2f,1f},
			{319.5f,3f,2f},
			{419.5f,4f,3f},
			{519.5f,5f,4f},
			{619.5f,7f,5f},
			{419.5f,8f,3f},
		};
		//上記はあくまでテスト


	}


	
	// Update is called once per frame
	void Update () {
	}
}
