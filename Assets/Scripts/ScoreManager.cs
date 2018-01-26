using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public int scoreKeep;
    public Text scoreUpdate;
    public static ScoreManager scoreManager;
    public GameObject startScreen;
    public GameObject optionsScreen;
    public GameObject exitScreen;
    public GameObject playButton;

    private void Start()
    {
        scoreManager = this;
        StartScreenOn();
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 0.2f;
        }
	}

    public void AddScore()
    {
        scoreKeep++;
        scoreUpdate.text = scoreKeep.ToString();
    }

    public void RemoveScore()
    {
        scoreKeep -=5;
        scoreUpdate.text = scoreKeep.ToString();
    }

    public void NoScore()
    {
            Time.timeScale = 0;
    }

    public void StartScreenOn()
    {
        startScreen.SetActive(true);
        optionsScreen.SetActive(false);
        exitScreen.SetActive(false);
    }

    public void OptionsScreenOn()
    {
        Time.timeScale = 0;
        startScreen.SetActive(true);
        optionsScreen.SetActive(true);
        exitScreen.SetActive(false);
    }

    public void ExitScreenOn()
    {
        Time.timeScale = 0;
        startScreen.SetActive(true);
        optionsScreen.SetActive(true);
        exitScreen.SetActive(true);
    }

    public void StartGame()
    {
        SpawnObjects.spawnObjects.StartThisGame();
        Time.timeScale = 1;
        startScreen.SetActive(false);
        optionsScreen.SetActive(false);
        exitScreen.SetActive(false);
        playButton.SetActive(false);
    }
}
