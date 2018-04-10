using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public Transform expandHor1,expandHor2,expandVer1,expandVer2;
    float lenghtmax = 3f, counter = 1.5f;
	public static bool Isrightlenght = false;
    Vector3 HoriEx = new Vector3(0.5f, 0f, 0f);
    Vector3 VerEx = new Vector3(0f, 0f, 0.5f);
    Vector3 HoriCenShif = new Vector3(0.25f, 0f, 0f);
    Vector3 VerCenShif = new Vector3(0f, 0f, 0.25f);
    void Update () {
        counter -= Time.deltaTime;
        if (counter <= 0)
        {
            expand();         
        }
	}
    void expand()
    {
		if (expandHor1.localScale.x <= lenghtmax) {
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
		if(expandHor1.localScale.x >= lenghtmax){
			Isrightlenght = true;
		}
    }
}
