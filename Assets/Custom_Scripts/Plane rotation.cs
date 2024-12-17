using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotatePlane : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, horizontal, Space.World);
        transform.Rotate(Vector3.right, vertical, Space.World);
    }
}