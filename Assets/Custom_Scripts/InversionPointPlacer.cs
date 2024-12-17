using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InversionPointPlacer : MonoBehaviour
{
    public Transform[] snapPoints; // Array of snap point positions
    public GameObject experimentMolecule; // Reference to the experiment molecule

    private int currentSnapIndex = 0; // Track the current snap point index
    private Vector3 initialInversionPointPosition; // Initial position of the inversion point
    private Vector3 initialMoleculePosition; // Initial position of the experiment molecule
    private Quaternion initialMoleculeRotation; // Initial rotation of the experiment molecule

    void Start()
    {
        // Store the initial position of the inversion point
        initialInversionPointPosition = transform.position;

        // Store the initial position and rotation of the experiment molecule
        if (experimentMolecule != null)
        {
            initialMoleculePosition = experimentMolecule.transform.position;
            initialMoleculeRotation = experimentMolecule.transform.rotation;
        }
        else
        {
            Debug.LogError("Experiment molecule not assigned!");
        }
    }

    void Update()
    {
        // Check if the user presses the Space key to move the inversion point
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaceInversionPoint();
        }

        // Check if the user presses the R key to reset the inversion point and experiment molecule
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPositions();
        }
    }

    void PlaceInversionPoint()
    {
        // Move the inversion point to the current snap point's position
        transform.position = snapPoints[currentSnapIndex].position;

        // Update the index to the next snap point in the array
        currentSnapIndex = (currentSnapIndex + 1) % snapPoints.Length;
    }

    void ResetPositions()
    {
        // Reset the inversion point to its initial position
        transform.position = initialInversionPointPosition;

        // Reset the experiment molecule to its initial position and rotation
        if (experimentMolecule != null)
        {
            experimentMolecule.transform.position = initialMoleculePosition;
            experimentMolecule.transform.rotation = initialMoleculeRotation;
        }

        // Reset the snap index to the first snap point
        currentSnapIndex = 0;

        Debug.Log("Reset: Inversion point and experiment molecule returned to initial positions.");
    }
}
