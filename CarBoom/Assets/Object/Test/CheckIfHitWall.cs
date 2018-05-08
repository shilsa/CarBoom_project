using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfHitWall : MonoBehaviour {
	public static bool HitWall = false;
	void Update(){
		if (!HitWall) {
			Moving.v = 8f;
		}
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "UnbreakableBrick(Clone)") {
			Moving.v = 0f;
			HitWall = true;
		}
	}
}
