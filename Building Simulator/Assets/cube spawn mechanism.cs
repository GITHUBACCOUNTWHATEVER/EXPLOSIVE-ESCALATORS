using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubespawnmechanism : MonoBehaviour
{

    public GameObject cubePrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))   
        {
            Instantiate(cubePrefab, transform.position, Quaternion.identity);
        }

    }
}
