using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier_controller : MonoBehaviour
{
    private int health = 0;
    public Sprite[] sprites; // sprites array

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[health]; 
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
        {
            Destroy(this.gameObject); // hit 3 times then destroy
            return;
        }
       
        GetComponent<SpriteRenderer>().sprite = sprites[health]; // contiunue to draw sprite 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); // destroy when collided
        health++;
    }
}
