using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThroughDelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	/*
	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "icon") {
			
			//int H = TapDelete.hit;
			//if(H == 1){
				//Destroy(gameObject);
			//}

			Debug.Log ("通過");
			//Destroy (gameObject, 5.0f);
		}
	}*/

	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -250f) {
			Debug.Log ("通過");
			Destroy (this.gameObject);
		}
	}
}
