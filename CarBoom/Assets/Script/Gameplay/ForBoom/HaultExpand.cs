using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaultExpand : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.name == "Explosionn") {
			Explosion.H1hit = true;
		}
		if (col.gameObject.name == "Explosionn (1)") {
			Explosion.H2hit = true;
		}
		if (col.gameObject.name == "Explosionn (2)") {
			Explosion.V1hit = true;
		}
		if (col.gameObject.name == "Explosionn (3)") {
			Explosion.V2hit = true;
		}
	}
}
