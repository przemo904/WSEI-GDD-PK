using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Text LivesText;
    public Text BallNumberText;

    
    public static int LivesNumber = 5;

    private void Update()
    {
        BallNumberText.text = "Ilość kul w środku: " + BallGenerator.BallNumbers;
        LivesText.text = "Ilość żyć: " + LivesNumber;

        if(BallGenerator.BallNumbers >= 10)
        {
            Debug.Log("You Win");

        } 

        if(LivesNumber <= 0)
        {
            Debug.Log("You Lose");
            Time.timeScale = 0;

        }
    }


}
