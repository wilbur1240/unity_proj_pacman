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
        if (collision.gameObject.tag == "Ghost")
        {
            Debug.Log("Game over !!!");
            LoadScene();
        }
    }

    void LoadScene()
    {
        Application.LoadLevel("SampleScene");
    }
}
