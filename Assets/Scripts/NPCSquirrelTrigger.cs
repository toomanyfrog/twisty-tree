using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NPCSquirrelTrigger : MonoBehaviour {

	bool inTrigger = false;
	bool gotKey = false;
	public GameObject text;
	public GameObject text2;
	public GameObject text3;
	public GameObject key;

	public Text nutCount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			inTrigger = true;
			if (gotKey) {
				text3.SetActive(true);
			}
			else if (collectObject.nutCount >= 5) {
				text2.SetActive(true);
				key.SetActive(true);
				collectObject.nutCount -= 5;
				nutCount.text = "x" + collectObject.nutCount.ToString ();
				gotKey = true;
			} else {
				text.SetActive (true);
			}
		}
	}

	void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			inTrigger = false;
			text.SetActive(false);
			text2.SetActive (false);
			text3.SetActive (false);
		}
	}
}
