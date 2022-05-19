using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        {
            ContinueMovement();
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            Destroy(gameObject);
            PlayerManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }
    private void ContinueMovement()
    {
        float xMove = Input.GetAxis("Horizontal");
        float xMovement = xMove * speed * Time.deltaTime;
        transform.Translate(xMovement, 0, 0);
    }
}

   