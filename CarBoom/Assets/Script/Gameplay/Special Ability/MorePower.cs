using System.Collections;
using UnityEngine;

public class MorePower : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            if (Explosion.lenghtmax < 15f)
            {
                Explosion.lenghtmax += 1f;
            }
            Destroy(gameObject);
        }
    }
}
