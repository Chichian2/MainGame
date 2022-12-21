using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPlace : MonoBehaviour
{
    public bool isOnStove = false;
    public GameObject Stove;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Stove)
        {
            isOnStove = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Stove)
        {
            isOnStove = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
