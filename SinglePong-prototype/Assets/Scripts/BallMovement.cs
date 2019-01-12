using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    [SerializeField] float speed = 20f;

  
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

        if (distance > 6.5f) {
            Debug.Log("You Died");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //transform.Rotate(new Vector3(0, 0, ));
        
    }

}
