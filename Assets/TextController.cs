using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	private RectTransform myRectfm;
	private Text myText;
	private GameObject canvas;
	private float stopPosX = 0f;
	private float textSpeedX = -2f;

	void Awake(){
		canvas = GameObject.Find ("Canvas");
		myRectfm = GetComponent<RectTransform> ();
		myText = GetComponent<Text> ();
	}

	// Use this for initialization
	void Start () {
		//SyncTextObj (myText);
	}
	
	// Update is called once per frame
	void Update () {
		if (stopPosX >= 0) {
			transform.Translate (textSpeedX, 0, 0);
		}
	}


	public void SyncTextObj(string text){
		transform.SetParent (canvas.transform);

		myRectfm.anchoredPosition = new Vector2 (10f, Random.Range (-200f, 200f));

		myText.text = text;

		myRectfm.sizeDelta = new Vector2 (myText.preferredWidth, myText.preferredHeight);
	}


}
