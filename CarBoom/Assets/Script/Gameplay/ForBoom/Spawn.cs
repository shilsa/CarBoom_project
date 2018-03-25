using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn : MonoBehaviour {

	public Transform sPos;
	public GameObject sOb;
	public int Bombnumcur = 0;
	MoreBoom mb = new MoreBoom();
	void Update () {
		if(Bombnumcur < mb.Bombmax){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (sOb, sPos.position, sPos.rotation);
			Bombnumcur++;
		}
	}
	}
}
