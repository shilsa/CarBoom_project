using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWallDes : MonoBehaviour {
    public static bool isDes = false;

    void OnCollisionEnter(Collision col) {
        if (isDes) {
            float x = transform.localPosition.x;
            float z = transform.localPosition.z;
            Border.UnBrePo[(int)(( x - 1)/2),(int)((z -1)/2)] = 0;
            Debug.Log("Wall at X: "+ (x - 1) / 2 + " Z: " + (z - 1) / 2 + " is destroyed");
            isDes = false;
        }
    }
}
