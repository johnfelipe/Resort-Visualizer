using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class stores a list of all public variables that a client would need to adjust.
/// </summary>
public class Manager : MonoBehaviour {
    [Header("Camera System Settings")]
    public GameObject startingPointOfIntrest;
    [Tooltip("Focus Speed changes how fast the focus point moves around the model.")]
    public float focusMovementSpeed;
    [Tooltip("Invert is disabled when checked")]
    public bool invertInput;
    public float cameraRotateSpeed;
    public float mouseSensitivityX;
    public float mouseSensitivityY;
    public float scrollSensitivity;
    public float mobileSensitivity;
    public float mobileSensitivityZoom;
    public int maxZoom;
    public int minZoom;
    public float autoOrbitTimout;
    public float autoOrbitSpeed;

    [Header("HUD Settings")]
    public float introFadingSpeed;

    [Header("Carousel Settings")]
    public bool test2;

    [Header("Daylight System Settings")]
    public bool test3;
}
