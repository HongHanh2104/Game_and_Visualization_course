using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remilia_move : MonoBehaviour
{
    Vector2 newPos;
    public float speed = 0.5f;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -8)
        {
            direction = 1;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (transform.position.x > 7)
        {
            direction = -1;
            GetComponent<SpriteRenderer>().flipX = true;
        }

        newPos.x += direction * speed * Time.deltaTime;

        transform.position = newPos;

    }
    
}
