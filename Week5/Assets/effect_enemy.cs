using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        /*
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");
        }
        */

    }
    
}
