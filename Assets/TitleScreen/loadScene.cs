using UnityEngine;
using System.Collections;

public class loadScene : MonoBehaviour {

	void Start() {
		Screen.SetResolution (1600, 900, true);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			Application.LoadLevel (1);
		}
	}
}
