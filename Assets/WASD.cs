using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float speedX, speedY, speedZ;
    private float y = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            Debug.Log("W");
            transform.Translate(0,y,1);
        }    

        if (Input.GetKey(KeyCode.S)) 
        {
            transform.Translate(0,y,-1);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate(-1,y,0);
        }

        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(1,y,0);
        }
    }
}
