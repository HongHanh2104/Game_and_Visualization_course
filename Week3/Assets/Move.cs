using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Vector2 newPos;
    public float speed = 1.0f;
    public float jump = 200f;
    // Start is called before the first frame update
    void Start()
    {
        //newPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //newPos.x -= speed;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Animator>().SetTrigger("Run");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //newPos.x += speed;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<Animator>().SetTrigger("Run");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
        }
    }
}
