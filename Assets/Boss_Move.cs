using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Move : MonoBehaviour
{
    public int hp2 = 100;
    float moveLR = 0.5f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x <= -15.0f)
        {
            transform.position = new Vector3(-15.0f, 15.7f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x >= 10.0f)
        {
            transform.position = new Vector3(10.0f, 15.7f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "magicStick")
        {
            hp2 = hp2 - 10;
            Debug.Log("Boss: -10!");

            if (hp2 <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
