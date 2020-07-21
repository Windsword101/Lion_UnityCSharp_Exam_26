using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed ;
    public GameObject box;
    // Start is called before the first frame update
   
    public Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
       //rb.AddForce(transform.forward* speed);
        transform.Translate(new Vector3(0, 0, 0.1f * speed));
    }
}

