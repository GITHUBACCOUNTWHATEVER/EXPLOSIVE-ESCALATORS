using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class playercontroller : MonoBehaviour
{


    float speed = 0.25f;
     public float JumpPower = 2f;
    Rigidbody rb;
   
   
    void Update()
    {
      if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += Vector3.forward * speed;
        }
      if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed;
        }
      if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed;
        }
      if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed;
        }
    }  
}
