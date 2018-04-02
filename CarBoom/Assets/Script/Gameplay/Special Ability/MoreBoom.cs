using System.Collections;
using UnityEngine;

public class MoreBoom : MonoBehaviour {
	Collision other1;
	public static int Bombmax = 1;
	void Start () {
		OnCollisionEnter (other1);
	}
	void Update(){ 
		

	}
	void OnCollisionEnter(Collision col)

	{
		if (col.gameObject.name == "Cube") {
			Bombmax++;  
			Destroy (gameObject);
		}
	}
}
