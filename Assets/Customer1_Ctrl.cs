using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer1_Ctrl : MonoBehaviour
{
    float currentTime = 0;
    float offsetTime = 3;
    public GameObject pfCustomer1;

    void Start()
    {
        Destroy(gameObject, 20.0f);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > offsetTime)
        {
            Instantiate(pfCustomer1, transform.position, transform.rotation);
            currentTime = 0;
        }
    }
}