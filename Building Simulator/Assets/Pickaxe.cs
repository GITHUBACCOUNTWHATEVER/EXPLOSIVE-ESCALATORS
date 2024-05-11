using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour
{
     float PickaxeRotationSpeed = 1.0f;

    private bool IsSwinging;
    private float PickaxeRotationAngle;
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Q)) 
        {
        IsSwinging = true; 
        }
        if (IsSwinging == true)
        {
            PickaxeRotationAngle += PickaxeRotationSpeed;
            transform.rotation = Quaternion.Euler(PickaxeRotationAngle, 0, 0);
            if (PickaxeRotationAngle > 90.0f)
            {
                PickaxeRotationAngle = 0.0f;
                IsSwinging = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
