using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour {

	public GameObject spawnObject;
	public float interval = 5f;
	Vector2 createPoint;
	GameObject parent;

	//public Vector3 posit = new Vector3 (-10, 0, 0);

	//private int index = 0;

	// Use this for initialization
	void Start () {
		StartSpawn ();

	}
	
	// Update is called once per frame
	void Update () {
		
		//if (Beat.timer >= Beat.timing [index] - 1) {
		createPoint = new Vector2(Random.Range(419.5f,419.5f), Random.Range(500f,500f));
			//index++;
		//}
	}


	IEnumerator SpawnNotes(){
		parent = GameObject.FindGameObjectWithTag("Canvas");
		while (true) {
			Instantiate(spawnObject, createPoint, transform.rotation, parent.transform);
			yield return new WaitForSeconds (1f);
		}
	}


	public void StartSpawn(){
		StartCoroutine ("SpawnNotes");
	}

	public void StopSpawn(){
		StopCoroutine ("SpawnNotes");
	}



}
