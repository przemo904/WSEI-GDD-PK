using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    [SerializeField] float speed = 30f;
    
  
    
    Vector2 direction;
    private Rigidbody2D rb2d;
    float distance;
    private void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector3(0, 0, Random.Range(0,360)));
        rb2d.AddForce(transform.up * speed);
    }

    private void FixedUpdate()
    {
        distance = Vector2.Distance(transform.position, new Vector2(0, 0));

        if (distance > 7.5f) {
            //Debug.Log("You Died");
            Destroy(gameObject);
            BallGenerator.BallNumbers--;
            LevelManager.LivesNumber--;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("Ball")) {
           
            Destroy(gameObject);
            BallGenerator.BallNumbers--;
        }
        if (collision.gameObject.tag.Equals("Player"))
        {

            

        }
        
    }

}
