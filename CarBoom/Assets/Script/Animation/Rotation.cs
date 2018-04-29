using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
		float hor = Input.GetAxis("Horizontal"), ver = Input.GetAxis("Vertical");
		if (hor > 0) {
			transform.Rotate (0f, 90f, 0f);
		} 
		else if (hor < 0) {
			transform.Rotate (0f, -90f, 0f);
		}
		if (ver > 0) {
			transform.Rotate (0f, 0f, 0f);
		} else if (ver < 0) {
			transform.Rotate (0f, 180f, 0f);
		}
	}
}
