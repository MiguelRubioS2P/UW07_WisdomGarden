using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
    public GameObject playerPrefabs;

    private void OnTriggerStay(Collider other)
    {
        //Instantiate(playerPrefabs);
        if (other.gameObject.name == "FPSController")
        {
            Instantiate(playerPrefabs);
        }
    }
}
