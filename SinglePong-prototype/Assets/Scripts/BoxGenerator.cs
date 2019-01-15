using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour {

    public GameObject Box;
    public static int BoxNumber = 1;
	void Start () {
        CreateBox();

	}

    public void CreateBox() {
        
        Instantiate(Box);
        BoxNumber++;
    }


    private void FixedUpdate()
    {
        if (Bonus.square)
        {
            Bonus.square = false;

            CreateBox();
        }
    }

}
