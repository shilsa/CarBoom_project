using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	public float lftime = 2f;

	// Update is called once per frame
	void Update () {
		lftime -= Time.deltaTime;
		if (lftime <= 0) {
			Des ();
		}
	}
	void Des(){
		Destroy (this.gameObject);
	}
}
