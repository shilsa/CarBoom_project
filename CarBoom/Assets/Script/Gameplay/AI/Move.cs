﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
		transform.Translate (Time.deltaTime * 3f, 0f, 0f);
	}
}