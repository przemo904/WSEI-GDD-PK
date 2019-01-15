using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGenerator : MonoBehaviour {

    public GameObject square;

    

    private void Start()
    {
        Instantiate(square);
        StartCoroutine(CreateSquare());

    }


    IEnumerator CreateSquare() {

        
        yield return new WaitForSeconds(10);
        Destroy(Bonus.prevSquare);
        Instantiate(square);
        
        StartCoroutine(CreateSquare());
    }
    
}
