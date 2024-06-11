using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicStick_Move : MonoBehaviour
{
    public GameObject pfSleep;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Customer1")
        {
            Instantiate(pfSleep, transform.position, transform.rotation);
        }
    }
}
