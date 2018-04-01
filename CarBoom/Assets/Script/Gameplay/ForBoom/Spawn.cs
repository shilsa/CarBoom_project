using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public Transform sPos;
	public GameObject sOb;
	public int Bomnum = 1;
	
	// Update is called once per frame
	void Update () {
		print (Input.GetKey(KeyCode.Space));
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(sOb, sPos.position,sPos.rotation);
		}
	}
}
