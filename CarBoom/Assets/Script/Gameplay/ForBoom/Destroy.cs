using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

	public float lftime = 3f;

	// Update is called once per frame
	void Update () {
		lftime -= Time.deltaTime*4f;
		if (lftime <= 0) {
			Des ();
		}
	}
	void Des(){
		Destroy (this.gameObject);
		Spawn.Bombnumcur--;
	}
}
