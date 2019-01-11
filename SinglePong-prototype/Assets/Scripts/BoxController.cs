using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

    [SerializeField] Transform rotationCenter; //Take position from Center(Empty Game Object).
    [SerializeField] float rotationRadius = 6f; //Set distance from rotationCenter. 
    [SerializeField] float[] speed = new float[2] {0.1f,0.3f }; //Set speed of the Box. First is normal speed. Second is faster speed(Hold space).


    private float posX, posY; //Position of the next Box co-ordinates in space.
    private float angle = 0f; //An angle which will help to find posX and posY. Quarters in a circle (0-360).

    private bool left = false, right = false; // If Player press the key change values on true.
    private int space = 0; //If 0 - normal speed. If 1 - faster speed.   

    private void FixedUpdate()
    {
        TakeInputFromPlayer();
        NextPosition();
        
        RotateBox();
    }

    private void TakeInputFromPlayer()
    {
        //When Player press the key.
        if (Input.GetKey("left")){
            left = true;
        }
        if (Input.GetKey("right"))
        {
            right = true;
        }
        if (Input.GetKey("space"))
        {
            space = 1;
        }
        //When Player realese the key.
        if (!Input.GetKey("left"))
        {
            left = false;
        }
        if (!Input.GetKey("right"))
        {
            right = false;
        }
        if (!Input.GetKey("space"))
        {
            space = 0;
        }

    }

    private void RotateBox() {

        var dir = transform.position - rotationCenter.position;
        var angleBox = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg ;
        transform.rotation = Quaternion.AngleAxis(angleBox, Vector3.forward);
        
    }


    private void NextPosition()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle-1.57f) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle-1.57f) * rotationRadius;
        Debug.Log(angle);
        transform.position = new Vector2(posX, posY);


        if (right == true)
        {
            angle = angle + Time.deltaTime * speed[space];
        }
        if (left == true)
        {
            angle = angle - Time.deltaTime * speed[space];
        }

        if (angle >= 360f) { angle = 0f; }

    }

}
