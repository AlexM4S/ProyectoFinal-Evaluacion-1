using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = new Vector3(0, 100, 0);

    public float speed = 5;

    public float movY = 200f;
    public float maxX = 200f;
    public float minX = 0f;
    public float movZ = 200f;
    

    private float horizontalInput;
    private float verticalInput;

    private float turnSpeed = 70;

    public GameObject proyectilePrefab;

    private AudioSource playerAudioSource;
    public AudioClip shotClip;



    // Start is called before the first frame update
    void Start()
    {
        // spawn en 0, 100, 0

        transform.position = initialPos;

        // sonido

        playerAudioSource = GetComponent<AudioSource>();

        // Couroutine

        StartCoroutine("SpawnRandomTarget");

    }

    
    // Update is called once per frame
    void Update()

    {
        // Límites

        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        if (transform.position.y > movY)

        {
            transform.position = new Vector3(transform.position.x, movY, transform.position.z);
        }

        if (transform.position.y < -movY)

        {
            transform.position = new Vector3(transform.position.x, -movY, transform.position.z);
        }

        if (transform.position.x > maxX)

        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }

        if (transform.position.x < minX)

        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if (transform.position.z > movZ)

        {
            transform.position = new Vector3(transform.position.x, transform.position.y, movZ);
        }

        if (transform.position.z < -movZ)

        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -movZ);
        }

        // Rotaciones

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);

        // Proyectil

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(proyectilePrefab, transform.position, proyectilePrefab.transform.rotation = transform.rotation);

            playerAudioSource.PlayOneShot(shotClip, 1);
        }

       
    }
}
