using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonChanger : MonoBehaviour
{

    private Manager manager;

    private ColorBlock colors;
    private Text font;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        if (manager == null) print("The Manager object is missing or broken!");
        else
        {
            try
            {
                colors = GetComponent<Button>().colors;
                if (colors != null)
                {
                    colors.normalColor = manager.primaryColor;
                    colors.highlightedColor = manager.hoverColor;
                    colors.disabledColor = manager.disabledColor;
                    colors.pressedColor = manager.activeColor;
                    GetComponent<Button>().colors = colors;
                }
                font = GetComponentInChildren<Text>();
                if (font != null) font.color = manager.textColor;
            }
            catch (Exception e)
            {
                //print(e);
            }
        }
    }
}

