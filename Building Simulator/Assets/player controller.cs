using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class playercontroller : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;
     public float JumpPower = 2f;
    Rigidbody rb;
   
   
    void Update()
    {
      if (Input.GetKey(KeyCode.W)) 
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
      if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }  
}
