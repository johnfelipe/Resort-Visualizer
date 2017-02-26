using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class controls the points of interest. It is attached to every PoI and every PoI has a UI button.
/// Here is where we store the new cameras position and rotation info.
/// </summary>
public class POIController : MonoBehaviour {

    /// <summary>
    /// Desired camera position and rotation
    /// </summary>
    [Range(-179.0f, 179.0f)]
    public float desiredYaw;
    [Range(1.0f, 75.0f)]
    public float desiredPitch;
    [Range(5.0f, 25.0f)]
    public float desiredZoom;

    private GameObject cameraSystem = null;
    private CameraMovement cm;

    void Start()
    {
        cameraSystem = GameObject.FindGameObjectWithTag("Camera System");
        if (cameraSystem == null) print("Camera system is missing or broken");
        else cm = cameraSystem.GetComponent<CameraMovement>();
    }

    public void UpdatePOI()
    {
        cm.MoveCamera(gameObject);
    }
}
