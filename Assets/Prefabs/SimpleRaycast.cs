using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRaycast : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 10f))
        {
            Debug.Log("Hit object: " + hit.collider.name);
        }
    }
}
