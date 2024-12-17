using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementJoystickControl : InputSystemGlobalListener, IMixedRealityInputHandler<Vector2>
{
    public MixedRealityInputAction Movement;
    public float speed = 1.0f;

    public void OnInputChanged(InputEventData<Vector2> eventData)
    {
        if (eventData.MixedRealityInputAction == Movement)
        {
            Debug.Log($"Movement detected: {eventData.InputData}");
            
            Vector3 localDelta = new Vector3(eventData.InputData.x, 0, eventData.InputData.y) * speed;
            transform.position = transform.position + transform.rotation * localDelta;
        }
    }
}
