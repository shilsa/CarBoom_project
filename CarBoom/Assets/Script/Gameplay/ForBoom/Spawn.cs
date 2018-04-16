using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public Transform sPos;
	public GameObject sOb;
	public static int Bombnumcur = 0;
	
	// Update is called once per frame
	void Update () {
		if(Bombnumcur < MoreBoom.Bombmax){
			if (Input.GetKeyDown (KeyCode.Space)) {
				Instantiate (sOb, sPos.position, sPos.rotation);
				print (Bombnumcur);
				Bombnumcur++;
			}
		}
	}
}
