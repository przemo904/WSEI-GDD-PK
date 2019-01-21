using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            StartCoroutine(BackToMenu());
            Time.timeScale = 0;
        } 

        if(LivesNumber <= 0)
        {
            EndText.text = "You Died";
            StartCoroutine(BackToMenu());
            Time.timeScale = 0;

        }
    }

    

    IEnumerator BackToMenu() {

        yield return new WaitForSecondsRealtime(3);
        SceneManager.LoadScene(0);


    }

}
