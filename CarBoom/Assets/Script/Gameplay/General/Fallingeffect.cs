using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallingeffect : MonoBehaviour {

	public Transform Border;
	public Transform Car;
	public Transform Monster;
	public Transform Monster2;
	public Transform Monster3;
	public static bool DoneFalling = false;

	void Update () {
		if (!DoneFalling) {
			if (Border.position.y > 0.75f) {
				Border.Translate (0f, (-3f) * Time.deltaTime, 0f);
				Monster.Translate (0f, (-3f) * Time.deltaTime, 0f);
				Monster2.Translate (0f, (-3f) * Time.deltaTime, 0f);
				Monster3.Translate (0f, (-3f) * Time.deltaTime, 0f);
			}
			if (Car.position.y > 0.5f) {
				Car.Translate (0f, (-3f) * Time.deltaTime, 0f);
			}
			if (Car.position.y <= 0.5f) {
				DoneFalling = true;
			}
		} 
	}
}
