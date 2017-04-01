using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TapArea : Button, ICanvasRaycastFilter {


	[SerializeField]
	float radius = 50f;

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return Vector2.Distance (sp, transform.position) < radius;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
