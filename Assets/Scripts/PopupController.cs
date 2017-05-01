using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupController : MonoBehaviour {

    private bool isOpen = false;
    private float moveValue = Screen.height /3;

    public void TogglePopup()
    {
        if (isOpen)
        {
            isOpen = false;
            transform.position = new Vector3(transform.position.x, transform.position.y - moveValue, transform.position.z);
        }else
        {
            isOpen = true;
            transform.position = new Vector3(transform.position.x, transform.position.y + moveValue, transform.position.z);
        }
    }
}
