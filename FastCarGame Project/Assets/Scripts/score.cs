using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour {

    public gameReset reset;

    public float playerScore;
    public float highScore;
    public float timer = 0;
    public bool running = false;

    public Text scoreText;
    public Text highScoreText;

    

    public void Start()
    {
        highScore = PlayerPrefs.GetFloat("Highscore");

        if(highScore == 0)
        {
            highScore = 100;
            highScoreText.text = highScore.ToString();
        }

        else if(highScore > 0)
        {
            highScoreText.text = highScore.ToString();
        }

        reset = GetComponent<gameReset>();
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "start") {
            running = true;
        }

        if (col.gameObject.name == "end") {
            running = false;
            playerScore = timer;

            if (playerScore < highScore)
            {
                highScore = playerScore;
                PlayerPrefs.SetFloat("Highscore", highScore);
                highScoreText.color = Color.green;
                highScoreText.text = highScore.ToString();
            }

        }
    }

    public void Update()
    {
        if(running == true)
        {
            timer += Time.deltaTime;
            scoreText.text = timer.ToString();
        }

		if(Input.GetKeyDown( "p" )){
            PlayerPrefs.SetFloat("Highscore", 1337);
            reset.hardRestartGame();
		}

    }
}


