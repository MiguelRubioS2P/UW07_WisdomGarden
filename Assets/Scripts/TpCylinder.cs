﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpCylinder : MonoBehaviour
{

    private Vector3 posicionCilindroSalida = new Vector3(25,22,-24);
    private Vector3 posicionCilindroEntrada;
    private bool dentro = false;
    
    
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.name == "FPSController")
        {
            other.gameObject.SetActive(false);
            posicionCilindroEntrada = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            dentro = true;
            other.gameObject.transform.position = posicionCilindroSalida;
            other.gameObject.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "FPSController")
        {
            dentro = false;
            //other.gameObject.transform.position = posicionCilindroSalida;
            //Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && dentro)
        {
            Debug.Log(posicionCilindroEntrada);
            
        }
    }

}
