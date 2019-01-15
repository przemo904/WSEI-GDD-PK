using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {

    public GameObject ball;
    bool inside = false;
    public static int BallNumbers = 1;


    private void Start() {
        Instantiate(ball);
        StartCoroutine(CreateBall());

    }

    IEnumerator CreateBall() {

        yield return new WaitForSeconds(3);


        if (inside == false || BallNumbers == 0)
        {
            Instantiate(ball);
            BallNumbers++;

        }
        
        StartCoroutine(CreateBall());
    }
 
   
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            inside = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        inside = false;
        
    }

    
}
