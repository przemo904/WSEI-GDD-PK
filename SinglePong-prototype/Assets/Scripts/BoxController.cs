using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour {

    Transform rotationCenter; //Take position from Center.

    [SerializeField] float rotationRadius = 6f; //Set distance from rotationCenter. 
    [SerializeField] float[] speed = new float[2] {2f,6f }; //Set speed of the Box. First is normal speed. Second is faster speed(Hold space).


    private float posX, posY; //Position of the next Box co-ordinates in space.
    private float angle = 0f; //An angle which will help to find posX and posY.

    private bool left = false, right = false, up = false, down = false; // If Player press the key change values on true.
    private int space = 0; //If 0 - normal speed. If 1 - faster speed.   
    float BoxAngle;
    float HelpAngleRot = 0;
    private void Awake()
    {
        rotationCenter = GameObject.FindGameObjectWithTag("Center").transform;

        BoxAngle = 1.57f + BoxGenerator.BoxNumber* Random.Range(1,100);
        
    }

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
        if (Input.GetKey("down"))
        {
            down = true;
        }
        if (Input.GetKey("up"))
        {
            up = true;
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
        if (!Input.GetKey("down"))
        {
            down = false;
        }
        if (!Input.GetKey("up"))
        {
            up = false;
        }

    }

    private void RotateBox() {

        var dir = transform.position - rotationCenter.position;
        var angleBox = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg ;
        

        if (down == true && HelpAngleRot < 45)
        {
            HelpAngleRot = HelpAngleRot + Time.deltaTime * 200f;
        }
        if (up == true && HelpAngleRot > -45)
        {
            HelpAngleRot = HelpAngleRot - Time.deltaTime * 200f;
        }
        //Debug.Log(HelpAngleRot);
        transform.rotation = Quaternion.AngleAxis(angleBox + HelpAngleRot, Vector3.forward);
        
    }


    private void NextPosition()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle-BoxAngle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle-BoxAngle) * rotationRadius;
        
        transform.position = new Vector2(posX, posY);


        if (right == true)
        {
            angle = angle + Time.deltaTime * speed[space];
        }
        if (left == true)
        {
            angle = angle - Time.deltaTime * speed[space];
        }

       
    }

}
