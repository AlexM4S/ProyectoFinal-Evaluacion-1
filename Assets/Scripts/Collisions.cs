using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{

    public float score;
    public bool gameOver = false;

    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Bad"))
        {
            Destroy(otherTrigger.gameObject);
            Destroy(gameObject);
            Debug.Log("GAME OVER");
        }

        else if (otherTrigger.gameObject.CompareTag("Good"))
        {
            Destroy(otherTrigger.gameObject);
            score = score + 1;
        }

        if (score == 10)
        {
            gameOver = true;
        }

       
    }

}
