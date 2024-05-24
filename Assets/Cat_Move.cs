using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat_Move : MonoBehaviour
{
    float moveLR = 1.5f;
    // int bullet = 0;
    // Score_Ctrl score;

    void Start()
    {
        // Destroy(gameObject, 20.0f);
        // score = GameObject.Find("Score").GetComponent<Score_Ctrl>();
    }

    void Update()
    {
        transform.Translate(-moveLR * Time.deltaTime, 0, 0);
        if (transform.position.x <= -5.0f)
        {
            transform.position = new Vector3(-5.0f, 13.2f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x >= 12.0f)
        {
            transform.position = new Vector3(12.0f, 13.2f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Book")
        {
            bullet = bullet + 1;
            if (bullet == 1)
            {
                score.scoreNum += 30;
                Destroy(gameObject);
            }
        }
    }
    */
}
