using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCollision : MonoBehaviour
{

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(gameObject.name);
    //    if (collision.gameObject.name == "Projectile(Clone)" || collision.gameObject.name == "Gun")
    //    {
    //        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 2, gameObject.transform.localScale.y / 2, gameObject.transform.localScale.z / 2);
    //    }

    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);

        if (other.gameObject.name == "Projectile(Clone)" || other.gameObject.name == "FPSController")
        {
            //gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x / 2, gameObject.transform.localScale.y / 2, gameObject.transform.localScale.z / 2);
            gameObject.transform.localScale /= 2;
        }
    }

}
