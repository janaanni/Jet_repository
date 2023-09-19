using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMethod : MonoBehaviour
{
    public GameObject jetComponent;
    private bool isVisible = true;

    public void Toggle()
    {
    if (isVisible) 
        {
            jetComponent.SetActive(false);
            isVisible = false;
        }
        else
        {
            jetComponent.SetActive(true);
            isVisible = true;
        }
    }
}
