using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNote : MonoBehaviour {

	public GameObject note;

	public Vector3 posit = new Vector3 (-10, 0, 0);

	private int index = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Beat.timer >= Beat.timing [index] - 1) {
			CreateNote ();
			index++;
		}
		*/
	}


	public void Create(){
		Instantiate (note, this.transform.position, this.transform.rotation);
	}


}
