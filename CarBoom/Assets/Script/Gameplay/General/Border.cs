using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

	public static float[,] UnBrePo = new float[100,100];
	// Unbreakable is 1
	// Breakable is 2
	public GameObject Sob;
	public Transform Spos;
	void Start () {

		float oriz = Spos.localPosition.z;
		for (int i = 0; i < 16; i++) {
			int temp2 = 0;
			float orix = Spos.localPosition.x;
			float neworix = orix;
			for (int j = 0; j < 16; j++) {
				int temp = i % 2;
				if (i == 0 || i == 15) {
					Vector3 spos = new Vector3 (orix, Spos.position.y, oriz);
					Instantiate (Sob, spos, Spos.rotation);
					int corx = (int) ((orix + 1) / 2);
					int corz = (int) ((oriz + 1) / 2);
					UnBrePo [corx,corz] = 1;
	//				Debug.Log ("The Bor at " + corx + " " +corz+" has the condition of:  "+UnBrePo [corx,corz]);
				} 
				else if (j == 0 || j == 15) {
					Vector3 spos = new Vector3 (orix, Spos.position.y, oriz);
					Instantiate (Sob, spos, Spos.rotation);
					int corx = (int) ((orix + 1) / 2);
					int corz = (int) ((oriz + 1) / 2);
					UnBrePo [corx,corz] = 1;
		//			Debug.Log ("The Bor at " + corx + " " +corz+" has the condition of:  "+UnBrePo [corx,corz]);
				}
				else if(temp == 0 && i != 14 && temp2 < 6){
					if (temp2 == 0) {
						neworix += 2.0f;
					}
					Vector3 spos = new Vector3 (neworix + 2f, Spos.position.y, oriz);
					Instantiate (Sob, spos, Spos.rotation);
					neworix += 4.0f;
					int corx = (int) ((neworix - 1f) / 2);
					int corz = (int) ((oriz + 1f) / 2);
					UnBrePo [corx,corz] = 1;
				//	Debug.Log ("The Bor at " + corx + " " +corz+" has the condition of:  "+UnBrePo [corx,corz]);
					temp2++;
				}
				orix += 2.0f;
			}
			oriz += 2.0f;
		}
		SpawnBreakBor.BorisDone = true;
	}

	void Update () {
		
	}
}
