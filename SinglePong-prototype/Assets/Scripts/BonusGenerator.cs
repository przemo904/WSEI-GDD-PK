using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGenerator : MonoBehaviour {

    public GameObject square;

    private void Start()
    {
        Instantiate(square);
    }



}
