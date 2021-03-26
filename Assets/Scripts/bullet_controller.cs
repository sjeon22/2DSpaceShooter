using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet_controller : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed); // bullet comes into existence, set its velocity
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>(); // find ScoreText and find text component
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.WorldToViewportPoint(transform.position).y > 1) // have we gone above the viewport
        {
            scoreText.GetComponent<score_controller>().score -= 5; // when bullet goes beyond the screen
            scoreText.GetComponent<score_controller>().UpdateScore(); // lose 5 points, update score
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // when collison happens between two objects with colliders
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(this.gameObject); // destroy bullet
            GameObject.Destroy(collision.gameObject); // destroy enemy
            scoreText.GetComponent<score_controller>().score += 10; // get the script attached to it, and add to score variable 10
            scoreText.GetComponent<score_controller>().UpdateScore(); // hit enemy, add 10, update
        }
    }
}
