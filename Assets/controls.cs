﻿using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Application.LoadLevel (0);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.CancelQuit();
		}
	}
}
