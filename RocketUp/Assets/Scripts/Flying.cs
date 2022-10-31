using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{

    public Rigidbody2D rb;
    public AudioSource audioEngine;
    //public ParticleSystem fireFromEngine;
    //public GameObject objectEngine;
    

    public float quatX;
    public float speedY;
    public float speedX;
    public float quat;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        fireFromEngine.Stop();
    }

    void Update()
    {
        objectEngine.transform.rotation = transform.rotation;

        if (Input.GetKeyDown(KeyCode.W))
        {
            audioEngine.Play();
            fireFromEngine.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audioEngine.Stop();
            fireFromEngine.Stop();
        }

        quatX = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.rotation *= Quaternion.Euler(0f, 0f, -quatX * speedX);
        }
        if (Input.GetKey(KeyCode.A))
        {

            rb.transform.rotation *= Quaternion.Euler(0f, 0f, -quatX * speedX);
        }


        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector2 (0f, speedY));
            
        }
      
        
    }
}
