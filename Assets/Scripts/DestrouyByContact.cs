using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrouyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject explosionPlayer;
    void OnCollisionEnter2D(Collision2D other)
    {
        //create an explosion and position it properly
        Instantiate(explosion, transform.position, transform.rotation);

        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionPlayer, other.transform.position, other.transform.rotation);
        }

        //destroy "this" object
        //destroy the "other" object
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
