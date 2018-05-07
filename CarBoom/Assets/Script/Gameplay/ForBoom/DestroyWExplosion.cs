using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWExplosion : MonoBehaviour {
    
	void OnCollisionEnter(Collision col){
		if (col.gameObject.name != "Plane" && col.gameObject.name != "Explosionn" && col.gameObject.name != "Explosionn2" && col.gameObject.name != "Explosionn3" && col.gameObject.name != "Explosionn4" && col.gameObject.name != "Boom4(Clone)" && col.gameObject.name != "UnbreakableBrick(Clone)" && col.gameObject.name != "Car") {
            Destroy (col.gameObject);
            if (col.gameObject.name == "Breakablewall(Clone)") {
                CheckWallDes.isDes = true;
            }
				if (col.gameObject.name == "Car") {
					Debug.Log ("Hit Car");
				}
		}
        if (col.gameObject.name == "Car") {
			EndGame end = new EndGame();
        }
	}
}
