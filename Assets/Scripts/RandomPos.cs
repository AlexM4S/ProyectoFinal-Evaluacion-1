using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPos : MonoBehaviour
{

    public float movY = 200f;
    public float maxX = 200f;
    public float minX = 0f;
    public float movZ = 200f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = RandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RandomPosition()

    {
        // aleatorizar posicion cajas objetivo

        float randomPosX = Random.Range(minX, maxX);
        float randomPosY = Random.Range(movY, -movY);
        float randomPosZ = Random.Range(movZ, -movZ);

        return new Vector3(randomPosX, randomPosY, randomPosZ);
    }
}
