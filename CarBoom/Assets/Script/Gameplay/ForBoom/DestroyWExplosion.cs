using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWExplosion : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name != "Plane" && col.gameObject.name != "Explosionn" && col.gameObject.name != "Explosionn2" && col.gameObject.name != "Explosionn3" && col.gameObject.name != "Explosionn4" )
		Destroy (col.gameObject);
		if (col.gameObject.name == "Cube") {
			Debug.Log ("Testing2");
		}
	}
}
