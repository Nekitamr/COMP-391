using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrouyByContact : MonoBehaviour
{
    public GameObject explosion;
    void OnCollisionEnter2D(Collision2D other)
    {
        //create an explosion and position it properly
        Instantiate(explosion, transform.position, transform.rotation);
        //destroy "this" object
        //destroy the "other" object
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
