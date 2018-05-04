using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

	public GameObject Sob;
	public float lftime = 1f;
	void Update () {
		lftime -= Time.deltaTime*2f;
		if (lftime <= 0) {
			Des ();
		}
	}
	void Des(){
		Instantiate (Sob, this.transform.position, this.transform.rotation);
		Destroy (this.gameObject);
		Spawn.Bombnumcur--;
	}
}
