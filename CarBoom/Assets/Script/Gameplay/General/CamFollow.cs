using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

	public Transform tar;
	public float v = 0.25f;
	public Vector3 campos;

	void FixedUpdate(){
		if (CameraMovementControl.InPos) {
			Vector3 destipos = tar.position + campos;
			Vector3 processedPos = Vector3.Lerp (transform.position, destipos, v);
			transform.position = processedPos;
		}
	}
}
