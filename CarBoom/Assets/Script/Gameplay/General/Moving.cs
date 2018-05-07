using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	public static float v = 8f;
   

    void Update () {
		if (Fallingeffect.DoneFalling && CameraMovementControl.InPos) {
			if (Input.GetKey(KeyCode.D) )
			{
				transform.Translate(Time.deltaTime * v, 0f, 0f);
				Rrr.PlaySound("Rrr");

			}

			else if (Input.GetKey(KeyCode.A) )
			{
				Rrr.PlaySound("Rrr");
				transform.Translate(Time.deltaTime * v * (-1), 0f, 0f);

			}
			if (Input.GetKey(KeyCode.W) ) {
				transform.Translate (0f, 0f, Time.deltaTime * v);
				Rrr.PlaySound("Rrr");
			}
			else if (Input.GetKey(KeyCode.S) ) {
				transform.Translate (0f, 0f, Time.deltaTime * v*(-1));
				Rrr.PlaySound("Rrr");
			}
		}
}
}
