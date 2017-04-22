using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapButton : MonoBehaviour {

	//タップしてノーツを消す処理



	public float timer = 0;
	public float timing;
	public float no;


	// Use this for initialization
	void Start () {
	}

	public void OnClick(){
		Debug.Log ("tap");
		//TimeManager timecount = GetComponent<TimeManager>();
		//float x = timecount.timer;
		//Debug.Log (x);
		Debug.Log(timer);

		NoteStatus notedata = GetComponent<NoteStatus> ();
		timing = notedata.notesdata[0,1];
		float x = timer - timing;
		Debug.Log ("取得データ" + timing);


		no = notedata.notesdata [0, 2];
		Debug.Log (no);

		//float x = timer - 8.737627f;
		if (x < 0) {
			x *= -1;
		}



		if(x < 1){
			Debug.Log ("LL");
			MyCanvas.SetActive (gameObject.name, false);
			//これでターゲットが消える
			//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
			//条件としてエリア内のターゲットを消すようにしたい
			//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい
		}

		if(timer == 9.850921f){
			Debug.Log ("L");
			MyCanvas.SetActive (gameObject.name, false);
			//これでターゲットが消える
			//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
			//条件としてエリア内のターゲットを消すようにしたい
			//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい
		}

		if(timer == 10.73707f || timer == 13.82695f){
			Debug.Log ("C");
			MyCanvas.SetActive (gameObject.name, false);
			//これでターゲットが消える
			//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
			//条件としてエリア内のターゲットを消すようにしたい
			//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい
		}


		if(timer == 11.68561f){
			Debug.Log ("R");
			MyCanvas.SetActive (gameObject.name, false);
			//これでターゲットが消える
			//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
			//条件としてエリア内のターゲットを消すようにしたい
			//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい
		}

		if(timer == 12.76384f){
			Debug.Log ("RR");
			MyCanvas.SetActive (gameObject.name, false);
			//これでターゲットが消える
			//これだとどこにいてもターゲットが消える上に同じタグ全てのターゲットが消える
			//条件としてエリア内のターゲットを消すようにしたい
			//エリア内で反応をしてさらには先頭のノーツに対して反応するようにしたい
		}





	}


	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		//Debug.Log (timer);
	}
}
