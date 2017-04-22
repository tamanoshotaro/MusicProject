using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] notes;//
	private float[] _timing;
	private int[] _lineNum;

	public string filePass;
	private int _notesCount = 0;//

	private AudioSource _audioSource;//
	private float _startTime = 0;//

	public float timeOffset = -1;//

	private bool _isPlaying = false;//
	public GameObject startButton;//ここないはず

	public Text scoreText;//
	private int _score = 0;//


	void Start () {
		_audioSource = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();//
		_timing = new float[1024];
		_lineNum = new int[1024];
		LoadCSV();
	}

	//ここから
	void Update(){
		if (_isPlaying) {
			CheckNextNotes ();
			scoreText.text = _score.ToString ();
		}
	}

	public void StartGame(){
		startButton.SetActive (false);
		_startTime = Time.time;
		_audioSource.Play ();
		_isPlaying = true;
	}

	void CheckNextNotes(){
		while (_timing [_notesCount] + timeOffset < GetMusicTime () && _timing [_notesCount] != 0) {
			SpawnNotes (_lineNum [_notesCount]);
			_notesCount++;
		}
	}

	void SpawnNotes(int num){
		Instantiate (notes [num], new Vector3 (-4.0f + (2.0f * num), 10.0f, 0), Quaternion.identity);
	}


	//ここまで



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
	}

	//ここから
	float GetMusicTime(){
		return Time.time - _startTime;
	}

	public void GoodTimingFunc(int num){
		Debug.Log ("Line:" + num + " good!");
		Debug.Log (GetMusicTime());
		_score++;
	}
	//ここまで
}
