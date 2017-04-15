using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TagAdd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AddTag ("Button-LL");
		AddTag ("Button-L");
		AddTag ("Button-C");
		AddTag ("Button-R");
		AddTag ("Button-RR");
	}

	static void AddTag(string tagname){
		UnityEngine.Object[] asset = AssetDatabase.LoadAllAssetsAtPath ("ProjectSettings/TagManager.asset");
		//if((asset ))
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
