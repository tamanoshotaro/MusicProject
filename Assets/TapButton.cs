using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapButton : MonoBehaviour {

	public int no;

	GameObject target;

	private NotesScript _notesScript;


	void Start () {
	}


	public void OnClick(){
		AudioClip clip = gameObject.GetComponent<AudioSource> ().clip;
		gameObject.GetComponent<AudioSource> ().PlayOneShot (clip);


		if (no == 0) {
			GameObject notes0 = GameObject.Find ("0");
			if (notes0 != null) {
				_notesScript = GameObject.Find ("0").GetComponent<NotesScript> ();
				GameObject targetLL = GameObject.FindGameObjectWithTag ("Button-LL");
				float target0 = targetLL.transform.position.y;
				//Debug.Log ("Y" + target0);
				if (95 <= target0 && target0 <= 115) {
					_notesScript.CheckInput ();
				} else if (60 <= target0 && target0 <= 135) {
					_notesScript.CheckInput2 ();
				} else if (50 <= target0 && target0 <= 145) {
					_notesScript.CheckInput3 ();
				} else if (40 < target0 && target0 < 150) {
					_notesScript.CheckInput4 ();
				}
			}
		}

		if (no == 1) {
			GameObject notes1 = GameObject.Find ("1");
			if (notes1 != null) {
				_notesScript = GameObject.Find ("1").GetComponent<NotesScript> ();
				GameObject targetL = GameObject.FindGameObjectWithTag ("Button-L");
				float target1 = targetL.transform.position.y;
				//Debug.Log ("Y" + target1);
				if (95 <= target1 && target1 <= 115) {
					_notesScript.CheckInput ();
				} else if (60 <= target1 && target1 <= 135) {
					_notesScript.CheckInput2 ();
				} else if (50 <= target1 && target1 <= 145) {
					_notesScript.CheckInput3 ();
				} else if (40 < target1 && target1 < 150) {
					_notesScript.CheckInput4 ();
				}
			}
		}

		if (no == 2) {
			GameObject notes2 = GameObject.Find ("2");
			if (notes2 != null) {
				_notesScript = GameObject.Find ("2").GetComponent<NotesScript> ();
				GameObject targetC = GameObject.FindGameObjectWithTag ("Button-C");
				float target2 = targetC.transform.position.y;
				//Debug.Log ("Y" + target2);
				if (95 <= target2 && target2 <= 115) {
					_notesScript.CheckInput ();
				} else if (60 <= target2 && target2 <= 135) {
					_notesScript.CheckInput2 ();
				} else if (50 <= target2 && target2 <= 145) {
					_notesScript.CheckInput3 ();
				} else if (40 < target2 && target2 < 150) {
					_notesScript.CheckInput4 ();
				}
			}
		}

		if (no == 3) {
			GameObject notes3 = GameObject.Find ("3");
			if (notes3 != null) {
				_notesScript = GameObject.Find ("3").GetComponent<NotesScript> ();
				GameObject targetR = GameObject.FindGameObjectWithTag ("Button-R");
				float target3 = targetR.transform.position.y;
				//Debug.Log ("Y" + target3);
				if (95 <= target3 && target3 <= 115) {
					_notesScript.CheckInput ();
				} else if (60 <= target3 && target3 <= 135) {
					_notesScript.CheckInput2 ();
				} else if (50 <= target3 && target3 <= 145) {
					_notesScript.CheckInput3 ();
				} else if (40 < target3 && target3 < 150) {
					_notesScript.CheckInput4 ();
				}
			}
		}

		if (no == 4) {
			GameObject notes4 = GameObject.Find ("4");
			if (notes4 != null) {
				_notesScript = GameObject.Find ("4").GetComponent<NotesScript> ();
				GameObject targetRR = GameObject.FindGameObjectWithTag ("Button-RR");
				float target4 = targetRR.transform.position.y;
				//Debug.Log ("Y" + target4);
				if (95 <= target4 && target4 <= 115) {
					_notesScript.CheckInput ();
				} else if (60 <= target4 && target4 <= 135) {
					_notesScript.CheckInput2 ();
				} else if (50 <= target4 && target4 <= 145) {
					_notesScript.CheckInput3 ();
				} else if (40 < target4 && target4 < 150) {
					_notesScript.CheckInput4 ();
				}
			}
		}
	}


	void Update () {
	}


}
