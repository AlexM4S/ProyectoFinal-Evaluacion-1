using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPos : MonoBehaviour
{
    private RandomPos SpawnPosScript;
    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPosScript = FindObjectOfType<RandomPos>();

        InvokeRepeating("SpawnObstacle", 0.1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, SpawnPosScript.RandomPosition(), obstaclePrefab.transform.rotation);
    }
}
