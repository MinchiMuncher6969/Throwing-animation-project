using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent_col : MonoBehaviour
{
    public GameObject theObjectToBeUnParented;
    public Rigidbody rb;

    private Transform PlayerTransform;
    public Transform ResetBall;

    public GameObject child;

    public Transform newParent;


    // Start is called before the first frame update
    private void Start()
    {
        rb.useGravity = false;
        rb = GetComponent<Rigidbody>();

        PlayerTransform = GameObject.Find("Ball").transform;

        
        
    }

    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "ThrowCol")
        {
            
            theObjectToBeUnParented.transform.SetParent(null);
            rb.useGravity = true;
            Debug.Log("Collided");

        }
        if (collision.gameObject.tag == "Player")
        {
            child.transform.SetParent(newParent);
            rb.useGravity = false;
            PlayerTransform.position = ResetBall.position;
            Debug.Log("Reset");
        }
    }
}





  




