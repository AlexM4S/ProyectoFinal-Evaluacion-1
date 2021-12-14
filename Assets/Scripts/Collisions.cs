using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public void OnTriggerEnter(Collider otherTrigger)
    {
        Destroy(otherTrigger.gameObject); // GameObject del animal
        Destroy(gameObject); // GameObject del proyectil

    }
}
