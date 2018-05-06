using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public Transform expandHor1,expandHor2,expandVer1,expandVer2;
	public float lenghtmax = 3f;
	public static bool H1hit = false, H2hit = false, V1hit = false, V2hit = false;

    Vector3 HoriEx = new Vector3(0.2f, 0f, 0f);
    Vector3 VerEx = new Vector3(0f, 0f, 0.2f);
    Vector3 HoriCenShif = new Vector3(0.1f, 0f, 0f);
    Vector3 VerCenShif = new Vector3(0f, 0f, 0.1f);
    void Update () {
		if(!H1hit)
            expandH1 ();
		if(!H2hit)
			expandH2 ();
		if(!V1hit)
			expandV1 ();
		if(!V2hit)
			expandV2 ();
		if (expandHor1.localScale.x >= lenghtmax || expandHor2.localScale.x >= lenghtmax || expandVer1.localScale.z >= lenghtmax || expandVer2.localScale.z >= lenghtmax) {
			Destroy (this.gameObject);
			rese ();
		}
		if (H1hit && H2hit && V1hit && V2hit) {
			Destroy (this.gameObject);
			rese ();
		}
	}
    void expandH1()
    {
		if (expandHor1.localScale.x <= lenghtmax) {
            expandHor1.localScale += HoriEx;
            expandHor1.localPosition += HoriCenShif;
        }					
    }
	void expandH2(){
		if (expandHor2.localScale.x <= lenghtmax)
		{
			expandHor2.localScale += HoriEx;
			expandHor2.localPosition -= HoriCenShif;
		}
	}

	void expandV1(){
		if (expandVer1.localScale.z <= lenghtmax)
		{
			expandVer1.localScale += VerEx;
			expandVer1.localPosition += VerCenShif;
		}
	}

	void expandV2(){
		if (expandVer2.localScale.z <= lenghtmax)
		{
			expandVer2.localScale += VerEx ;
			expandVer2.localPosition -= VerCenShif;
		}
	}

	void rese(){
		H1hit = false; H2hit = false; V1hit = false; V2hit = false;
	}
	public Explosion(){


	}
}
