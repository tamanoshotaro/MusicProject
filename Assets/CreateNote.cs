using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour {


	//ノーツの生成管理


	public GameObject spawnObject;
	public float interval = 5f;
	Vector2 createPoint;
	GameObject parent;

	public Vector3 posit = new Vector3 (-10, 0, 0);
	private int index = 0;
	public int p;


	public float timeOut;
	private float timeElapsed;

	//public float[] position = {219.5f, 319.5f, 419.5f, 519.5f, 619.5f};


	// Use this for initialization
	/*
	void Start () {
		
	}*/

	void Start () {
		//Debug.Log (index);
		//if (TapPoint.timer >= TapPoint.timing [index] - 1) {
		//int p = 0;
		for(p = 0; p < 5; p++){
			NoteStatus notepotition = GetComponent<NoteStatus> ();

			//int p = 0;
			//if(p < 7){
			NoteStatus note3 = GetComponent<NoteStatus> ();


				float x = note3.notesdata[p,0];
			float y = 500f;
			//ここでポイントの指定をしている
			//その読み取り先というのをどうするか…NotesStatusからが良いのか…？
			//ButtonLL → x = 219.5f  y = 500f
			//ButtonL  → x = 319.5f  y = 500f
			//ButtonC  → x = 419.5f  y = 500f
			//ButtonR  → x = 519.5f  y = 500f
			//ButtonRR → x = 619.5f  y = 500f

			createPoint = new Vector2 (Random.Range (x, x), Random.Range (y, y));
			//この生成ポイントを５か所にしたい
			//Rangeの()内をxとyにして代入する形式にした


			//StartSpawn ();

			SpawnNotes ();

				Debug.Log ("繰り返し" + p);
				//p++;
			//}

			/*
			if (TapPoint.timing.Length - 1 > index){
				index++;
				} else {
				Debug.Log ("終了");
					//ここに終了処理書きたい（とりあえず）
				}
				*/
				//Debug.Log (index);
			}

	}


	public void SpawnNotes(){
		parent = GameObject.FindGameObjectWithTag("Canvas");
			GameObject note = Instantiate(spawnObject, createPoint, transform.rotation, parent.transform);
			Transform note2 = note.GetComponent<Transform>();
			NoteStatus note3 = GetComponent<NoteStatus> ();
		if (note3.notesdata [p, 0] == 219.5f) {
			note2.gameObject.tag = "Button-LL";
		}
		if (note3.notesdata [p, 0] == 319.5f) {
			note2.gameObject.tag = "Button-L";
		}
		if (note3.notesdata [p, 0] == 419.5f) {
			note2.gameObject.tag = "Button-C";
		}
		if (note3.notesdata [p, 0] == 519.5f) {
			note2.gameObject.tag = "Button-R";
		}
		if (note3.notesdata [p, 0] == 619.5f) {
			note2.gameObject.tag = "Button-RR";
		}


	}


	/*
	public void StartSpawn(){
		StartCoroutine ("SpawnNotes");
	}

	public void StopSpawn(){
		StopCoroutine ("SpawnNotes");
	}*/

	void Update(){
		timeElapsed += Time.deltaTime;
		if (timeElapsed >= timeOut) {
			timeElapsed = 1.0f;
		}
		
	}


}
