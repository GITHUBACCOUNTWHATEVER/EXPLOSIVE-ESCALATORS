using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
    public Gameobject Grenade;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(Grenade, transform.position, Quaternion.identity);
        }

    }
}
