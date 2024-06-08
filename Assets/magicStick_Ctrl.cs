using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicStick_Ctrl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Customer1")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Customer2")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Customer3")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Dog")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Cat")
        {
            Destroy(other.gameObject);
        }
    }
}
