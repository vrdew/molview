using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import this to use UI elements like Slider
using Microsoft.MixedReality.Toolkit.UI;

public class MoleculeRotatorScript : MonoBehaviour
{
    public GameObject molecule;    // The molecule object
    public GameObject axis;        // The axis (red rod) around which the molecule will rotate

    public PinchSlider rotationSpeedPinchSlider; // Reference to the UI Slider for controlling rotation speed

    private float rotationSpeed;    // Speed of the rotation (set by the slider)
    private Quaternion initialRotation;    // To store the molecule's initial rotation

    public float rotationMultiplier = 10.0f;  // Multiplier to make the rotation more noticeable

    void Start()
    {
        // Initialize rotation speed from the slider's current value
        rotationSpeed = rotationSpeedPinchSlider.SliderValue * rotationMultiplier;

        // Add listener to handle value updates from the pinch slider
        rotationSpeedPinchSlider.OnValueUpdated.AddListener(UpdateRotationSpeed);

        // Store the initial rotation of the molecule when the script starts
        initialRotation = molecule.transform.rotation;
    }

    void Update()
    {
        // Update rotation speed based on the slider value in real-time
        rotationSpeed = rotationSpeedPinchSlider.SliderValue * rotationMultiplier;

        // Ensure that the axis is placed inside the molecule for proper rotation
        if (axis != null)
        {
            // Rotate the molecule about the axis's Y-axis (up vector)
            ApplySliderRotation();
        }
    }

    void ApplySliderRotation()
    {
        // Get the current rotation of the molecule
        Vector3 currentRotation = molecule.transform.rotation.eulerAngles;

        // We only modify the Y rotation based on the slider value
        // The X and Z rotations remain fixed as per the initial rotation of the molecule

        // Rotate the molecule around the axis's Y-axis (which is axis.transform.up)
        // This will apply a Y-rotation around the axis object, controlled by the slider
        molecule.transform.RotateAround(
            axis.transform.position,      // The position of the axis (this will be the pivot point)
            axis.transform.up,            // The Y-axis of the axis object is used for rotation
            rotationSpeed * Time.deltaTime // The speed of the rotation is controlled by the slider and multiplied by Time.deltaTime
        );
    }

    // Listener function that updates rotation speed based on the slider's value
    void UpdateRotationSpeed(SliderEventData data)
    {
        rotationSpeed = data.NewValue * rotationMultiplier;  // Apply multiplier to speed
        Debug.Log("Rotation Speed Updated: " + rotationSpeed);
    }
}