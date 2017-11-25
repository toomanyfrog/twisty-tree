﻿using UnityEngine;
using System.Collections;

public class SpriteReceiveShadows : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().shadowCastingMode =  UnityEngine.Rendering.ShadowCastingMode.On;
		GetComponent<Renderer>().receiveShadows = true;
	}

}
