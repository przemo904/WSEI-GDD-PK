using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour {

    public GameObject ball;

    void Start()
    {
       
            Instantiate(ball);
        
    }

}
