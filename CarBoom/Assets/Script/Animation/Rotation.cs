using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
		if (Input.GetKey(KeyCode.D)) {
			transform.localRotation = Quaternion.Euler(0.0f, 90.0f, 0.0f);
		} 
		else if (Input.GetKey(KeyCode.A)) {
			transform.localRotation = Quaternion.Euler(0.0f, -90.0f, 0.0f);
		}
		if (Input.GetKey(KeyCode.W)) {
			transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
		} else if (Input.GetKey(KeyCode.S)) {
			transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
		}
	}
}
