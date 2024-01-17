using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePower : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PowerPellet")
        {
            Debug.Log("Get PowerPellet !!!");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Maze")
        {
            Debug.Log("Collide wall !!!");
        }
    }
}
