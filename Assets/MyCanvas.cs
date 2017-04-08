using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCanvas : MonoBehaviour {

	static Canvas _canvas;

	// Use this for initialization
	void Start () {
		_canvas = GetComponent<Canvas> ();
		//gameObject.SetActive (false);
	}

	public static void SetActive(string name, bool b){
		Debug.Log ("test");
		foreach (Transform child in _canvas.transform) {
			if (child.tag == name && child.gameObject.active == true) { //==trueはなくても可 if文の中はtrue前提なので
				child.gameObject.SetActive (b);
				return;
			}
		}
		Debug.LogWarning ("Not found objname:" + name);
	}





	// Update is called once per frame
	void Update () {
		
	}
}
