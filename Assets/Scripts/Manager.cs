using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Player player;
    public Text scoreTxt;
    public GameObject RetryButton;
    public GameObject gameOver;
    public int score;
    
    void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play(){
        score = 0;
        scoreTxt.text = score.ToString();

        RetryButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for(int i=0; i<pipes.Length; i++){
            Destroy(pipes[i].gameObject);
        }        
    }    

    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver(){
        gameOver.SetActive(true);
        RetryButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore(){
        score++;
        scoreTxt.text = score.ToString();
    }
}
