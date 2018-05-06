using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpecial : MonoBehaviour {

	public GameObject Sob;
	public Transform Spos;
	int xmax = 15, zmax = 16;
	public static bool WallisDone = false;
	int counter = 0;
	int maxsp;
	void Start () {
		int temp = Random.Range (10,30 );
		maxsp = temp;
	}
	
	// Update is called once per frame
	void Update () {
		if (WallisDone) {
			while (true) {
				int xcor = Random.Range (2, xmax);
				int zcor = Random.Range (2, zmax);
				Vector3 sppo = new Vector3 ((float)(xcor * 2) - 1, 0.5f, (float)(zcor * 2) - 1);
				if (SpawnBreakBor.BrePo [xcor, zcor] == 1) {
					Instantiate (Sob, sppo, Spos.rotation);
					counter++;
				}
				if (counter == maxsp) {
					WallisDone = false;
					return;
				}
			}
		}
	}
}
