using System.Collections;
using UnityEngine;

public class PowerMax : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            Explosion.lenghtmax = 10f;
            Destroy(gameObject);
        }
    }
}
