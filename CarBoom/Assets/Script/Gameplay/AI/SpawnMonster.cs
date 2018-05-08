using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour {

	public GameObject Sob;
	public Transform Monster1;
	public Transform Monster2;
	public Transform Monster3;
	void Start(){
		Instantiate (Sob, Monster1.position, Monster1.rotation);
		Instantiate (Sob, Monster2.position, Monster2.rotation);
		Instantiate (Sob, Monster3.position, Monster3.rotation);
	}
}
