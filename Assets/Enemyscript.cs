using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscript : MonoBehaviour
{


    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

        // Update is called once per frame
        void Update()
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            PlayerManager.isGameOver = true;
            Destroy(collision.gameObject);
        }
    }
}
