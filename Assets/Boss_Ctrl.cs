using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Ctrl : MonoBehaviour
{
    float currentTime = 0;
    float offsetTime = 3;
    public GameObject pfBoss;

    void Start()
    {
        Destroy(gameObject, 20.0f);
    }

    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > offsetTime)
        {
            Instantiate(pfBoss, transform.position, transform.rotation);
            currentTime = 0;
        }
    }
}
