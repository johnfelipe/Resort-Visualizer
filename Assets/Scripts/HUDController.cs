using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class controls the HUDs functionality
/// </summary>
public class HUDController : MonoBehaviour {

    /// <summary>
    /// Public reference to the options menu
    /// </summary>
    public GameObject optionsMenu;

    /// <summary>
    /// Public reference to the sun
    /// </summary>
    public GameObject sun;

    /// <summary>
    /// Public references to the on/off switch sprites
    /// </summary>
    public Sprite switchOn;
    public Sprite switchOff;

    /// <summary>
    /// This value tells us if the options menu is open
    /// </summary>
    private static bool isOptions = false;

    /// <summary>
    /// This value tells us if icons are on or off
    /// </summary>
    private static bool isIcons = true;

    /// <summary>
    /// This value tells us if icons are on or off
    /// </summary>
    private static bool isSlideView = true;

    /// <summary>
    /// This value tells us if icons are on or off
    /// </summary>
    private static bool isDay = true;

    /// <summary>
    /// This function opens and closes the options (settings) menu on the HUD
    /// </summary>
    public void ToggleOptionsMenu()
    {
        if (isOptions)
        {
            isOptions = false;
            optionsMenu.SetActive(false);
        }else
        {
            isOptions = true;
            optionsMenu.SetActive(true);
        }
    }

    /// <summary>
    /// This function enables or disables icons
    /// </summary>
    public void ToggleIcons()
    {
        if (isIcons)
        {
            isIcons = false;
            GetComponent<Image>().sprite = switchOff;
        }
        else
        {
            isIcons = true;
            GetComponent<Image>().sprite = switchOn;
        }
    }

    /// <summary>
    /// This function enables or disables the slide view
    /// </summary>
    public void ToggleSlideView()
    {
        if (isSlideView)
        {
            isSlideView = false;
            GetComponent<Image>().sprite = switchOff;
        }else
        {
            isSlideView = true;
            GetComponent<Image>().sprite = switchOn;
        }
    }

    /// <summary>
    /// This function switchs between day and night
    /// </summary>
    public void ToggleDaylight()
    {
        if (isDay)
        {
            isDay = false;
            GetComponent<Image>().sprite = switchOff;
            sun.GetComponent<DaylightController>().ToggleDaylight();
        }
        else
        {
            isDay = true;
            GetComponent<Image>().sprite = switchOn;
            sun.GetComponent<DaylightController>().ToggleDaylight();
        }
    }
}
