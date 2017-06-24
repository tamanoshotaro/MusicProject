using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCanvas : MonoBehaviour {

	static Canvas _canvas;

	void Start () {
		_canvas = GetComponent<Canvas>();
	}


	public static void SetActive(string name, bool b){
		foreach (Transform child in _canvas.transform) {
			if (child.tag == name && child.gameObject == true) {//==trueはなくても可 if文はture前提なので
				Destroy(child.gameObject);
				return;
			}
		}
	}
		
	void Update () {
	}

}