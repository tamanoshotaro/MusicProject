using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "tag1") {
			Debug.Log ("通過");
			Destroy (gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
