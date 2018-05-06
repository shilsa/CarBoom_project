using System.Collections;
using UnityEngine;

public class MoreBoom : MonoBehaviour {
	public static int Bombmax = 1;
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Car") {
            AudioManScript.PlaySound("powup");
            Bombmax++;  
			Destroy (gameObject);
		}
	}
}
