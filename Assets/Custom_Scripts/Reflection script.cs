using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectMolecule : MonoBehaviour
{
    public Transform reflectionPlane;

    public void Reflect()
    {
        // Get the plane's normal and position
        Vector3 planeNormal = reflectionPlane.up;
        Vector3 planePosition = reflectionPlane.position;

        // Calculate the relative position of the molecule to the plane
        Vector3 relativePosition = transform.position - planePosition;

        // Reflect the relative position using the plane's normal
        Vector3 reflectedPosition = Vector3.Reflect(relativePosition, planeNormal);

        // Apply the reflected position back to world space
        transform.position = planePosition + reflectedPosition;

        // Optionally reflect the rotation as well
        Vector3 reflectedForward = Vector3.Reflect(transform.forward, planeNormal);
        Vector3 reflectedUp = Vector3.Reflect(transform.up, planeNormal);
        transform.rotation = Quaternion.LookRotation(reflectedForward, reflectedUp);
    }
}