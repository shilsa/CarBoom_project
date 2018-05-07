using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementControl : MonoBehaviour {

	public Transform[] cams;
	public float v;
	public static bool InPos = false;
	void Start () {
		v = 1f;
	}
	void LateUpdate(){
		if (!InPos) {
			transform.position = Vector3.Lerp (transform.position, cams[0].position, Time.deltaTime * v);
			transform.LookAt (cams[1]);
		}
		if ((transform.position.y - cams [0].position.y) <= 0.001) {
			InPos = true;
			Debug.Log ("Cam is in");
		}
	}
}
