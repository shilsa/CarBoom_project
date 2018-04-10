using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTEst : MonoBehaviour {
	
		public Transform expandHor1,expandHor2,expandVer1,expandVer2,Bomb;
		static int Bombcount = 1;
		float lenghtmax = 5f, counter = 1f;
		Vector3 HoriEx = new Vector3(0.5f, 0f, 0f);
		Vector3 VerEx = new Vector3(0f, 0f, 0.5f);
		Vector3 HoriCenShif = new Vector3(0.25f, 0f, 0f);
		Vector3 VerCenShif = new Vector3(0f, 0f, 0.25f);
		void Update () {			
			counter -= Time.deltaTime;
			if (counter <= 0)
			{
			expand(); 
			Bombcount = Spawn.Bombnumcur + 1;
			}
		if (Spawn.Bombnumcur > 0 && counter <= 0) {
			Instantiate (expandHor1, Bomb.position, Bomb.rotation);
			Instantiate (expandHor2, Bomb.position, Bomb.rotation);
			Instantiate (expandVer1, Bomb.position, Bomb.rotation);
			Instantiate (expandVer2, Bomb.position, Bomb.rotation);
			print ("Just testing");
		}
		}
		void expand()
		{
			if (expandHor1.localScale.x <= lenghtmax) {	
				Instantiate (expandHor1, Bomb.position, Bomb.rotation);
				expandHor1.localScale += HoriEx;
				expandHor1.localPosition += HoriCenShif;
			}
			if (expandHor2.localScale.x <= lenghtmax)
			{
				expandHor2.localScale += HoriEx;
				expandHor2.localPosition -= HoriCenShif;
			}
			if (expandVer1.localScale.z <= lenghtmax)
			{
				expandVer1.localScale += VerEx;
				expandVer1.localPosition += VerCenShif;
			}
			if (expandVer2.localScale.z <= lenghtmax)
			{
				expandVer2.localScale += VerEx ;
				expandVer2.localPosition -= VerCenShif;
			}
		Destroy1 ();
		}
		void Destroy1(){
		if (expandHor1.localScale.x >= lenghtmax) {
			print (expandHor1.localScale.x);
			Destroy (expandHor1);
			Destroy (expandHor2);
			Destroy (expandVer1);
			Destroy (expandVer2);
		}
	}
}
	
