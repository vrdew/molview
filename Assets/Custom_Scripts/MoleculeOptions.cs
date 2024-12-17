using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeOptions : MonoBehaviour
{
    public GameObject plane; // Reference to the plane object
    public GameObject molecule; // Reference to the molecule object

    // Method to handle reflection mode
    public void ChooseReflection()
    {
        // Ensure the plane is visible
        plane.SetActive(true);

        // Call your existing reflection logic here
        // Example: ReflectMolecule();
    }

    // Method to handle rotation mode
    public void ChooseRotation()
    {
        // Hide the plane, as it's not needed for rotation
        plane.SetActive(false);

        // Call your existing rotation logic here
        // Example: RotateMolecule();
    }

    // Optional method for rotating the molecule
    private void RotateMolecule()
    {
        // Example rotation logic for molecule
        molecule.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }

    // Optional method for reflecting the molecule
    private void ReflectMolecule()
    {
        // Example reflection logic
        Vector3 planeNormal = plane.transform.up;
        Vector3 relativePosition = molecule.transform.position - plane.transform.position;
        Vector3 reflectedPosition = Vector3.Reflect(relativePosition, planeNormal);
        molecule.transform.position = plane.transform.position + reflectedPosition;
    }
}