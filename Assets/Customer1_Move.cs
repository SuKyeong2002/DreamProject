using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer1_Move : MonoBehaviour
{
    float moveLR = 1.0f;
    // int bullet = 0;
    // Score_Ctrl score;

    void Start()
    {
        // Destroy(gameObject, 20.0f);
        // score = GameObject.Find("Score").GetComponent<Score_Ctrl>();
    }

    void Update()
    {
        transform.Translate(moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x <= -14.0f)
        {
            transform.position = new Vector3(-14.0f, -16.6f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (transform.position.x >= 12.0f)
        {
            transform.position = new Vector3(12.0f, -16.6f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}