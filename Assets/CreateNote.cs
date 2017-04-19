using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour {


	//ノーツの生成管理


	public GameObject spawnObject;
	Vector2 createPoint;
	GameObject parent;
	public int p;

	IEnumerator Start(){

		for(p = 0; p < 6; p++){
			NoteStatus notepotition = GetComponent<NoteStatus> ();

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



			SpawnNotes ();

				Debug.Log ("繰り返し" + p);
			yield return new WaitForSeconds (1.0f);


			}

	}

	void Cor(){
		StartCoroutine ("Start");
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
		


}
