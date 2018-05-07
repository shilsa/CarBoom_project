using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamsControl : MonoBehaviour {

	public Camera[] cams;
	void Update () {
		if (CameraMovementControl.InPos) {
			cams [0].enabled = true;
			cams [1].enabled = false;
		}
	}

}
