using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

	public static int[,] UnBrePo = new int[100,100];
	// Unbreakable is 1
	// Breakable is 2
	public GameObject Sob;
	public Transform Spos;
	void Start () {

		float oriz = Spos.localPosition.z;
		for (int i = 0; i < 16; i++) {
            {
                for (int j = 0; j < 16; j++)
                {
                    Vector3 Space = new Vector3((float)(i * 2 + 1), 1f, (float)(j * 2 + 1));
                    if (i == 0 || i == 14 || j == 0 || j == 14)
                    {
                        Instantiate(Sob, Space, Spos.rotation);
                        UnBrePo[i, j] = 1;
                    }
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Instantiate(Sob, Space, Spos.rotation);
                        UnBrePo[i, j] = 1;
                    }
                    else
                        UnBrePo[i, j] = 0;
                }
            }
		}
		SpawnBreakBor.BorisDone = true;
	}

	void Update () {
		
	}
}
