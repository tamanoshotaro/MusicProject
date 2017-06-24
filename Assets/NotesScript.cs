using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour {

	public int lineNum;
	private GameManager _gameManager;

	public GameObject TapEfect;

	public int CLcount = 0;

	//int y = 0;

	void Start () {
		_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}



	public void ComboLine(){
		_gameManager.ComboOut ();
	}
	

	void Update () { // * 350 *
		this.transform.position += Vector3.down * 350 * Time.deltaTime;//座標をマイナスして落としてる

		if (this.transform.position.y <= 40 && CLcount == 0) {
			//Debug.Log ("?????");
			//Debug.Log (this.transform.position.y);
			CLcount++;
			ComboLine ();
		}
		if (this.transform.position.y < -5.0f) { //座標-5以下でデリート
			Destroy (this.gameObject);
		}
	}
		


	public void CheckInput(){
		if (this.name == "0") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "1") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "2") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (0f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "3") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "4") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		}
		_gameManager.PerfectTimingFunc (lineNum);
		Destroy (this.gameObject);
	}

	public void CheckInput2(){
		if (this.name == "0") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "1") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "2") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (0f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "3") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "4") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		}
		_gameManager.GreatTimingFunc (lineNum);
		Destroy (this.gameObject);
	}


	public void CheckInput3(){
		if (this.name == "0") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "1") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "2") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (0f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "3") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "4") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		}
		_gameManager.GoodTimingFunc (lineNum);
		Destroy (this.gameObject);
	}

	public void CheckInput4(){
		if (this.name == "0") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "1") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (-2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "2") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (0f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "3") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (2.95f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		} else if (this.name == "4") {
			GameObject Eobj = Instantiate (TapEfect, new Vector3 (5.9f, -1.9f, 0f), Quaternion.identity);
			Destroy (Eobj, 1.5f);
		}
		_gameManager.MissTimingFunc (lineNum);
		Destroy (this.gameObject);
	}

}

//new Vector3 (0f, -1.9f, 0f)