using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Move : MonoBehaviour
{
    float moveLR = 0;
    float speed = 5.0f;
    Animator playerAni;
    Rigidbody2D playerRigid;

    void Start()
    {
        playerAni = GetComponent<Animator>();
        playerRigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveLR = Input.GetAxisRaw("Horizontal");
        transform.Translate(transform.right * moveLR * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigid.velocity = new Vector2(playerRigid.velocity.x, 0); // Y축 속도를 초기화
            playerRigid.AddForce(new Vector2(0, 5f), ForceMode2D.Impulse);
            playerAni.SetBool("isJump", true);
        }
        else
        {
            playerAni.SetBool("isJump", false);

            if (playerRigid.velocity.y != 0)
            {
                playerAni.SetBool("isJump", true);
            }
        }


        if (moveLR == -1 || moveLR == 1)
        {
            playerAni.SetBool("isRun", true);
            if (playerRigid.velocity.y != 0)
            {
                playerAni.SetBool("isJump", true);
                playerAni.SetBool("isRun", false);
            }
        }
        else
        {
            playerAni.SetBool("isRun", false);
        }

        if (moveLR == -1)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (moveLR == 1)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Start");
        }

        if (other.gameObject.tag == "Jack")
        {
            SceneManager.LoadScene("End");
        }
    }
}
