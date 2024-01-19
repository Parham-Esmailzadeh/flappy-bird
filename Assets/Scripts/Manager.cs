using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Player player;
    public Text scoreTxt;
    public GameObject RetryButton;
    public GameObject GameOver;
    public int score;
    
    void Awake(){
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play(){

    }    

    public void Pause(){
        Time.timeScale = 0f;
        player.enabled = false;
    }
    public void GameOver(){
        GameOver.SetActive(true);
    }

    public void IncreaseScore(){
        score++;
    }
}
