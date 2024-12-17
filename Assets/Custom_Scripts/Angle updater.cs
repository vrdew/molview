using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add this to use TextMesh Pro

public class AngleDisplay : MonoBehaviour
{
    public Transform plane; // The plane whose angle you want to display
    public Transform molecule; // The molecule whose reflected angle you want to display
    public TextMeshProUGUI angleMeterText; // The UI TextMeshPro element to display the angles

    private Quaternion initialPlaneRotation;
    private Quaternion initialMoleculeRotation;

    void Start()
    {
        // Store the initial rotations of the plane and molecule
        initialPlaneRotation = plane.rotation;
        initialMoleculeRotation = molecule.rotation;
    }

    void Update()
    {
        // Calculate the current angle of the plane relative to its initial rotation
        float planeAngle = Quaternion.Angle(initialPlaneRotation, plane.rotation);

        // Calculate the current angle of the molecule relative to its initial rotation
        float moleculeAngle = Quaternion.Angle(initialMoleculeRotation, molecule.rotation);

        // Update the UI TextMeshPro element with the angles
        angleMeterText.text = $"Plane Angle: {planeAngle:F2}°\nMolecule Angle: {moleculeAngle:F2}°";
    }
}
