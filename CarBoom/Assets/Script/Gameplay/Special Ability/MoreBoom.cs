using System.Collections;
using UnityEngine;

public class MoreBoom : MonoBehaviour {
	public static int Bombmax = 1;
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Car") {
			Bombmax++;  
			Destroy (gameObject);
		}
	}
}
