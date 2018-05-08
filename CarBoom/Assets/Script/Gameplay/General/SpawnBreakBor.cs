using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBreakBor : MonoBehaviour {

	public GameObject Sob;
	public Transform Spos;
    private System.Random ran;
	int xmax = 14, zmax = 14;
	public static int[,] BrePo = new int[100, 100];
	public static bool BorisDone = false;
	int counter = 0;
	int maxbor;

	void Start () {
        int temp = Random.Range(10, 20);
        maxbor = temp;
		Border.UnBrePo [1, 13] = 1;
		Border.UnBrePo [13, 1] = 1;
		Border.UnBrePo [1, 1] = 1;
		Border.UnBrePo [13, 13] = 1;
		Border.UnBrePo [2, 14] = 1;
		Border.UnBrePo [3, 14] = 1;
	}

	void Update () {
		if(BorisDone){
				int xcor = Random.Range (1, xmax);
				int zcor = Random.Range (1, zmax);
			Vector3 borpo = new Vector3 ((float)(xcor *2+1), 1f, (float)(zcor*2+1));
                if (Border.UnBrePo[xcor, zcor] == 1) ;
                else if (counter < maxbor)
                {
                    Instantiate(Sob, borpo, Spos.rotation);
                    counter++;
                    BrePo[xcor, zcor] = 1;
                    Border.UnBrePo[xcor, zcor] = 1;
                Debug.Log("Wall is " + xcor + " " + zcor +" is: " +Border.UnBrePo[xcor,zcor]);
                }
                else if (counter == maxbor)
                {
				Border.UnBrePo [1, 13] = 0;
				Border.UnBrePo [13, 1] = 0;
				Border.UnBrePo [1, 1] = 0;
				Border.UnBrePo [13, 13] = 0;
				Border.UnBrePo [2, 14] = 0;
				Border.UnBrePo [3, 14] = 0;
                    BorisDone = false;
                    SpawnSpecial.WallisDone = true;
                }
		}
	}
}
