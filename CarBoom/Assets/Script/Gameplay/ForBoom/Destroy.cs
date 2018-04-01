using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

	public float lftime = 2f;

	// Update is called once per frame
	void Update () {
		lftime -= Time.deltaTime;
		lftime -= Time.deltaTime*3.5f;
		if (lftime <= 0) {
			Des ();
		}
	}
	void Des(){
		Destroy (this.gameObject);
		Spawn.Bombnumcur--;
	}
}
