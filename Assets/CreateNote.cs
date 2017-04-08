using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour {

	public GameObject spawnObject;
	public float interval = 5f;
	Vector2 createPoint;
	GameObject parent;

	public Vector3 posit = new Vector3 (-10, 0, 0);
	private int index = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log (index);
		if (TapPoint.timer >= TapPoint.timing [index] - 1) {
			createPoint = new Vector2 (Random.Range (419.5f, 419.5f), Random.Range (500f, 500f));
			//StartSpawn ();
			SpawnNotes ();

			if (TapPoint.timing.Length - 1 > index) {
				index++;
			} else {
				//ここに終了処理書きたい（とりあえず）
			}
			Debug.Log (index);
		}
	}


	public void SpawnNotes(){
		parent = GameObject.FindGameObjectWithTag("Canvas");
		Instantiate(spawnObject, createPoint, transform.rotation, parent.transform);
	}


	/*
	public void StartSpawn(){
		StartCoroutine ("SpawnNotes");
	}

	public void StopSpawn(){
		StopCoroutine ("SpawnNotes");
	}*/



}
