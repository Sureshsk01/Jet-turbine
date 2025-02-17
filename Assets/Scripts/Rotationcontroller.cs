using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationcontroller : MonoBehaviour
{
    public Vector3 rotationvector;

    private void  Update()
     {
        transform.Rotate(rotationvector * Time.deltaTime);
    }

}
