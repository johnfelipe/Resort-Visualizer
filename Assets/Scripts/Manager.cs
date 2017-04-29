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
    [Tooltip("Fade-in speed")]
    public float introFadingSpeed;
    public Color primaryColor;
    public Color secondaryColor;
    public Color textColor;
    public Color hoverColor;
    public Color activeColor;
    public Color disabledColor;

    [Header("Carousel Settings")]
    [Tooltip("This is the amount of time the Camera System will spend at each POI")]
    public float carouselTimer;

    [Header("Daylight System Settings")]
    public float daylightIntensity;

    /// <summary>
    /// This is the list of Point of Interest objects, it is pouplated at runtime.
    /// </summary>
    private GameObject[] pois;

    /// <summary>
    /// These are our carousel variables
    /// </summary>
    private bool allowCarousel = true;
    private float carouselCountdown;
    private int currentPOI = 0;

    /// <summary>
    /// In this start funciton we will get references to all the POI objects
    /// We will also set our countdown timer to equal our desired time
    /// </summary>
    void Start()
    {
        if(pois == null)
        {
            pois = GameObject.FindGameObjectsWithTag("Point of Interest");
        }
        carouselCountdown = carouselTimer;
    }


    void Update()
    {
        if (allowCarousel)
        {
            carouselCountdown -= Time.deltaTime;

            if(carouselCountdown <= 0)
            {
                currentPOI++;
                if(currentPOI >= pois.Length)
                {
                    //If we are over, we will reset
                    currentPOI = 0;
                }
                //Reset the countdown
                carouselCountdown = carouselTimer;
                
                //Update POI
                pois[currentPOI].GetComponent<POIController>().UpdatePOI();
            }
        }
    }

    /// <summary>
    /// This function will allow us to change if the carousel is running or not
    /// </summary>
    /// <param name="newSetting"></param>
    public void ToggleCarousel(bool newSetting)
    {
        allowCarousel = newSetting;
    }

    /// <summary>
    /// This function will reset the carousels countdown timer when the user provides a new POI switch input.
    /// We also update our currentPOI value to match the new index number of our selected POI.
    /// </summary>
    /// <param name="target">This is the desired POI object</param>
    public void ResetCarousel(GameObject target)
    {
        carouselCountdown = carouselTimer;

        currentPOI = System.Array.IndexOf(pois, target);
    }
}
