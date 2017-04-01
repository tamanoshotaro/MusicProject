using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapDelete : MonoBehaviour {




	//public static int hit;

	//GameObject line;
	//float v;

	// Use this for initialization
	void Start () {
		//line = GameObject.Find("Target");
		//v = transform.position.y;
	}




	public void Tap(){
		Debug.Log ("タップされました");
		GameObject line = GameObject.Find("Target");
		float v = transform.position.y;

		GameObject area = GameObject.Find ("Panel(1)");
		//float p1 = transform.position.Anchors.Min.Y;
		//float p2 = transform.position.Anchors.Max.Y;
		/*
		if (p1 < v < p2) {
			Destroy(gameObject);
		}*/


	}
	


	
	// Update is called once per frame
	void Update () {
	}
}
