using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGod : MonoBehaviour
{
    private bool activo = false;
    private void OnTriggerEnter(Collider other)
    {       
        if (other.gameObject.name == "FPSController")
        {
            activo = true;
        } 
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            activo = false;
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R) && activo)
        {
            transform.Rotate(Vector3.forward * 2);
        }
    }

}
