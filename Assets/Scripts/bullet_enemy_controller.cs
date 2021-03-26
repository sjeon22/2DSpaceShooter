using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_enemy_controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed); // bullet comes into existence, set its velocity
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y < 0) // have we gone above the viewport
            Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) // when collison happens between two objects with colliders
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject.Destroy(this.gameObject); // destroy bullet
            GameObject.Destroy(collision.gameObject); // destroy enemy
        }
    }
}
