using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBreakBor : MonoBehaviour {

	public GameObject Sob;
	public Transform Spos;
	int xmax = 15, zmax = 16;
	public static float[,] BrePo = new float[100, 100];
	public static bool BorisDone = false;
	int counter = 0;
	int maxbor;

	void Start () {
		int temp = Random.Range (40,80 );
		maxbor = temp;
	}

	void Update () {
		if(BorisDone){
			while (true) {
				int xcor = Random.Range (2, xmax);
				int zcor = Random.Range (2, zmax);
				Vector3 borpo = new Vector3 ((float)(xcor * 2) - 1, 1f, (float)(zcor * 2) - 1);
				if (Border.UnBrePo[xcor, zcor] == 1) {

				} else if (counter != maxbor) {
					Instantiate (Sob, borpo, Spos.rotation);
					counter++;
					BrePo [xcor, zcor] = 1;
					Border.UnBrePo [xcor, zcor] = 1;
					Debug.Log (counter);
				} else if (counter == maxbor) {
					BorisDone = false;
					SpawnSpecial.WallisDone = true;
					return;
				}
			}
		}
	}
}
