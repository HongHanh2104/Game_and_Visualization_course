using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Vector2 newPos;
    public float speed = 10.0f;
    public float jump = 200f;
    private int max_jump = 2;
    public int cur_jump = 0;
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
        
        if (Input.GetKeyDown(KeyCode.Space) && cur_jump < max_jump)
        {
            cur_jump++;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));            
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground_long" || collision.gameObject.tag == "ground_short")
        {
            cur_jump = 0;
        }
        
    }
}
