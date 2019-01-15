using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour {

    public static bool square = false;
    public static GameObject prevSquare;
    private float posX, posY;

    private void Awake()
    {
        prevSquare = this.gameObject;
        posX = Random.Range(1, 4.5f)* PlusOrMinus();
        posY = Random.Range(1, 4.5f)* PlusOrMinus();

        transform.position = new Vector2(posX,posY);
    }
    private float PlusOrMinus()
    {
        float los = (float) Random.Range(-2f, 2f);
        //Debug.Log(los);
        if ( los > 0)
        {
            return 1;
        }
        else
        {

            return -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball")) {

            
            //Debug.Log("zderzenie z pilka");
            square = true;
            Destroy(gameObject);
            
        }
    }
}
