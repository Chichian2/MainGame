using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knob : MonoBehaviour
{

    public GameObject setting1;
    public GameObject setting2;
    public GameObject setting3;
    public int mode = 0;


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == setting1)
        {
            mode = 0;
        }
        else if(other.gameObject == setting3)
        {
            mode = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject== setting1)
        {
            mode = 1;
        }
        else if(other.gameObject == setting2)
        {
            mode = 2;
        }
        else if(other.gameObject == setting3)
        {
            mode = 3;
        }
    }

   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
