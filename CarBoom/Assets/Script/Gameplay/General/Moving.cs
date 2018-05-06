using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {

	static float v = 6f;
   

    void Update () {
		if (Input.GetKey(KeyCode.D) )
        {
            transform.Translate(Time.deltaTime * (v+SpeedUp.SpdUp), 0f, 0f);
            Rrr.PlaySound("Rrr");

        }

		else if (Input.GetKey(KeyCode.A) )
        {
            Rrr.PlaySound("Rrr");
            transform.Translate(Time.deltaTime * (v+SpeedUp.SpdUp) * (-1), 0f, 0f);


        }

        if (Input.GetKey(KeyCode.W)) {
			transform.Translate (0f, 0f, Time.deltaTime * (v+SpeedUp.SpdUp));
            Rrr.PlaySound("Rrr");
        }

        else if (Input.GetKey(KeyCode.S)) {
			transform.Translate (0f, 0f, Time.deltaTime * (v+SpeedUp.SpdUp)*(-1));
            Rrr.PlaySound("Rrr");
        }

    }
}
