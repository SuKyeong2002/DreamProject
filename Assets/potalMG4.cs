using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potalMG4 : MonoBehaviour
{
    public Transform exitPotal;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.position = exitPotal.position + new Vector3(2.0f, 0, 0); ;
        }
    }
}
