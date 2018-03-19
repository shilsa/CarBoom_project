using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	static float speed = 1f, v = 5f;

	void Update () {
		float hor = Input.GetAxis("Horizontal"), ver = Input.GetAxis("Vertical");
		if (hor > 0) {
			transform.Translate (Time.deltaTime * v, 0f, 0f);

		} 
		else if (hor < 0) {
			transform.Translate (Time.deltaTime*v*(-1), 0f, 0f);
		}
		if (ver > 0) {
			transform.Translate (0f, 0f, Time.deltaTime * v);
		} else if (ver < 0) {
			transform.Translate (0f, 0f, Time.deltaTime * v*(-1));
		}
	}
}
