using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CreateNote : MonoBehaviour {


	//ノーツの生成管理


	public GameObject spawnObject;
	Vector2 createPoint;
	GameObject parent;
	public int p;




	public GameObject[] notes;//
	private float[] _timing;
	private int[] _lineNum;

	public string filePass;
	private int _notesCount = 0;//

	private AudioSource _audioSource;//
	private float _startTime = 0;//

	public float timeOffset = -1;//







	IEnumerator Start(){
		_audioSource = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();//
		_timing = new float[1024];
		_lineNum = new int[1024];
		//LoadCSV(); エラー出るので一旦消し








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

	/*
	void LoadCSV(){
		int i = 0, j;
		TextAsset csv = Resources.Load (filePass) as TextAsset;
		StringReader reader = new StringReader (csv.text);
		while (reader.Peek () > -1) {
			string line = reader.ReadLine ();
			string[] values = line.Split (',');
			for (j = 0; j < values.Length; j++) {
				_timing [i] = float.Parse (values [0]);
				_lineNum [i] = int.Parse (values [1]);


				Debug.Log (_timing[0]);
				Debug.Log (_lineNum[0]);
			}
			i++;
		}
	}*/ //エラー出るので一旦隠し





	public void SpawnNotes(){
		parent = GameObject.FindGameObjectWithTag("Canvas");
			GameObject note = Instantiate(spawnObject, createPoint, transform.rotation, parent.transform);
			Transform note2 = note.GetComponent<Transform>();
			NoteStatus note3 = GetComponent<NoteStatus> ();


		if (note3.notesdata [p, 0] == 219.5f) {
			note2.gameObject.tag = "Button-LL";
			note2.gameObject.name = "" + note3.notesdata[p,2];
		}
		if (note3.notesdata [p, 0] == 319.5f) {
			note2.gameObject.tag = "Button-L";
			note2.gameObject.name = "" + note3.notesdata[p,2];
		}
		if (note3.notesdata [p, 0] == 419.5f) {
			note2.gameObject.tag = "Button-C";
			note2.gameObject.name = "" + note3.notesdata[p,2];
		}
		if (note3.notesdata [p, 0] == 519.5f) {
			note2.gameObject.tag = "Button-R";
			note2.gameObject.name = "" + note3.notesdata[p,2];
		}
		if (note3.notesdata [p, 0] == 619.5f) {
			note2.gameObject.tag = "Button-RR";
			note2.gameObject.name = "" + note3.notesdata[p,2];
		}


	}
		


}
