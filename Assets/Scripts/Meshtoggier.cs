using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meshtoggier : MonoBehaviour
{
    public GameObject Turbineobject;
    private bool isActive = true;

    public void Toggle()
    {
        if(isActive)
        {
            Turbineobject.SetActive(false);
            isActive = false;
        }
        else
        {
            Turbineobject.SetActive(true);
            isActive = true;
        }
    }
}
