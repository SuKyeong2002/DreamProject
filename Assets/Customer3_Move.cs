using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer3_Move : MonoBehaviour
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
        if (transform.position.x <= -7.0f)
        {
            transform.position = new Vector3(-7.0f, 5.1f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (transform.position.x >= 8.0f)
        {
            transform.position = new Vector3(8.0f, 5.1f, 0);
            moveLR *= -1;
            transform.rotation = Quaternion.Euler(0, 180, 0);
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
