using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject[] notes;
	private float[] _timing;
	private int[] _lineNum;

	public string filePass;
	private int _notesCount = 0;

	private AudioSource _audioSource;
	private float _startTime = 0;

	public float timeOffset = -1;

	private bool _isPlaying = false;
	public GameObject startButton;

	public Text scoreText;
	public /*private*/ int _score = 0;
	public Text comboText;
	private int _combo = 0;

	public int maxCombo = 0;
	public int nowCombo;

	public GameObject stageLight;

	public float check_time;
	private GameEnd _gameEnd;

	public GameObject endText;
	public int endCount = 0;
	public GameObject toNextButton;

	GameObject parent;

	// Use this for initialization
	void Start () {
		_audioSource = GameObject.Find ("GameMusic").GetComponent<AudioSource> ();
		_timing = new float[1024];
		_lineNum = new int[1024];
		LoadCSV ();
	}

	void Update(){
		if (_isPlaying) {
			CheckNextNotes ();
			scoreText.text = _score.ToString ();
			comboText.text = _combo.ToString ();

			float check_time2 = Time.realtimeSinceStartup - check_time;
			//Debug.Log ("check time : " + check_time2.ToString ("0.00000"));
			if (check_time2 >= 105 && endCount == 0) {
				Debug.Log ("終了");//ここに終了処理の発動を記入
				parent = GameObject.FindGameObjectWithTag ("Canvas");
				GameObject Etext = Instantiate (endText, new Vector2 (600f, 500f), Quaternion.identity, parent.transform);
				toNextButton.SetActive (true);
				//GameObject Nbotton = Instantiate (toNextButton, new Vector2(1600f, 100f),Quaternion.identity, parent.transform);
				endCount++;
				//_gameEnd.result();
			}
		}
	}


	public void StartGame(){
		startButton.SetActive (false);
		_startTime = Time.time;
		_audioSource.Play ();
		_isPlaying = true;

		GameObject STobj = Instantiate (stageLight, new Vector3 (0.25f, 8.45f, 0f), Quaternion.identity);

		check_time = Time.realtimeSinceStartup;
	}

	void CheckNextNotes(){
		while (_timing [_notesCount] + timeOffset < GetMusicTime () && _timing [_notesCount] != 0) {
			SpawnNotes (_lineNum [_notesCount]);
			_notesCount++;
		}
	}

	void SpawnNotes(int num){

		//lineNum = 0 → x = 219.5f  y = 500f
		//lineNum = 1 → x = 319.5f  y = 500f
		//lineNum = 2 → x = 419.5f  y = 500f
		//lineNum = 3 → x = 519.5f  y = 500f
		//lineNum = 4 → x = 619.5f  y = 500f

		//81.5f350f
		//181.5f
		//281.5f
		//381.5f
		//481.5f

		switch (num) {
		case 0:
			parent = GameObject.FindGameObjectWithTag ("Canvas");
			GameObject note0 = Instantiate (notes [num],
				                   new Vector2 (215f, 1100f),
				                   Quaternion.identity, parent.transform);
			note0.gameObject.tag = "Button-LL";
			note0.gameObject.name = "" + num;
			break;

		case 1:
			parent = GameObject.FindGameObjectWithTag ("Canvas");
			GameObject note1 = Instantiate (notes [num],
				                   new Vector2 (425f, 1100f),
				                   Quaternion.identity, parent.transform);
			note1.gameObject.tag = "Button-L";
			note1.gameObject.name = "" + num;
			break;
		case 2:
			parent = GameObject.FindGameObjectWithTag ("Canvas");
			GameObject note2 = Instantiate (notes [num],
				                   new Vector2 (635f, 1100f),
				                   Quaternion.identity, parent.transform);
			note2.gameObject.tag = "Button-C";
			note2.gameObject.name = "" + num;
			break;
		case 3:
			parent = GameObject.FindGameObjectWithTag ("Canvas");
			GameObject note3 = Instantiate (notes [num],
				                   new Vector2 (850f, 1100f),
				                   Quaternion.identity, parent.transform);
			note3.gameObject.tag = "Button-R";
			note3.gameObject.name = "" + num;
			break;
		case 4:
			parent = GameObject.FindGameObjectWithTag ("Canvas");
			GameObject note4 = Instantiate (notes [num],
				                   new Vector2 (1060f, 1100f),
				                   Quaternion.identity, parent.transform);
			note4.gameObject.tag = "Button-RR";
			note4.gameObject.name = "" + num;
			break;
		default:
			break;
		}

	}



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
			}
			i++;
		}
	}

	float GetMusicTime(){
		return Time.time - _startTime;
	}


	public void PerfectTimingFunc(int num){
		Debug.Log ("Line:" + num + "perfect!");
		Debug.Log (GetMusicTime());
		_combo++;
		_score += 3;

		nowCombo = _combo;
		if (nowCombo > maxCombo) {
			maxCombo = nowCombo;
			Debug.Log ("MAX : " + maxCombo);
		}

		//コンボ加点
		if (_combo >= 2) {
			_score += _combo;
		}
	}

	public void GreatTimingFunc(int num){
		Debug.Log ("Line:" + num + "great!");
		Debug.Log (GetMusicTime());
		_combo++;
		_score += 2;

		nowCombo = _combo;
		if (nowCombo > maxCombo) {
			maxCombo = nowCombo;
			Debug.Log ("MAX : " + maxCombo);
		}

		//コンボ加点
		if (_combo >= 2) {
			_score += _combo;
		}
	}


	public void GoodTimingFunc(int num){
		Debug.Log ("Line:" + num + "good!");
		Debug.Log (GetMusicTime());
		_combo = 0;
		_score++;
	}


	public void MissTimingFunc(int num){
		Debug.Log ("Line:" + num + "miss!");
		Debug.Log (GetMusicTime());
		_combo = 0;
	}

	public void ComboOut(){
		_combo = 0;
	}

}