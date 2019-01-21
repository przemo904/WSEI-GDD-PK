using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Text LivesText;
    public Text BallNumberText;
    public Text EndText;
    
    public static int LivesNumber = 5;

    private void Update()
    {
        BallNumberText.text = "Ilość kul w środku: " + BallGenerator.BallNumbers + "/10";
        LivesText.text = "Ilość żyć: " + LivesNumber;



        if(BallGenerator.BallNumbers >= 10)
        {

            EndText.text = "You Win!";
            Time.timeScale = 0;
        } 

        if(LivesNumber <= 0)
        {
            EndText.text = "You Died";
            Time.timeScale = 0;

        }
    }


}
