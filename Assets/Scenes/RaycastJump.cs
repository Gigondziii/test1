using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastJump : MonoBehaviour
{
    public float defectDistance = 2;
    public float jumpForce = 500;

    private void Update()
    {
            if(Physics.Raycast(transform.position,  Vector3.down, out RaycastHit hit, defectDistance))
            if (hit.transform.CompareTag("Floor") && Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            }

    }
}
