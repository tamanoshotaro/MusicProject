using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void OnClick(){
		Debug.Log ("tap");

		//gameObject.SetActive (false);
		//自身が消える…これを他のもの(エリア内のノーツ)が消えるようにしたい

		MyCanvas.SetActive (gameObject.name, false);
		//これでターゲットが消える
		//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
		//条件としてエリア内のターゲットを消すようにしたい
		//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい

	}


	// Update is called once per frame
	void Update () {
		
	}
}
