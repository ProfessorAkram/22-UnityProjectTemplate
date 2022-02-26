/**** 
 * Created by: Akram Taghavi-Burrs
 * Date Created: Feb 23, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 23, 2022
 * 
 * Description: Updates HUD canvas referecing game manager
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDCanvas : MonoBehaviour
{
    /*** VARIABLES ***/

    GameManager gm; //reference to game manager
    LevelManager lm; //reference to level manger

    [Header("Canvas SETTINGS")]
    public Text levelTextbox; //textbox for level count
    public Text livesTextbox; //textbox for the lives
    public Text scoreTextbox; //textbox for the score
    public Text highScoreTextbox; //textbox for highscore
    public Text timerTextbox; //textbox for timer
    public Text collecteablesTextbox; //textbox for collected count
    
    //GM Data
    private int level;
    private int totalLevels;
    private int lives;
    private int score;
    private int highscore;
    private string dispalyTime;
    private int collectableAmount;
    private int collectablesCollected;


    // Start is called before the first frame update
    private void Start()
    {
        gm = GameManager.GM; //find the game manager

        //reference to levle info
        level = gm.gameLevelsCount;
        totalLevels = gm.gameLevels.Length;
        SetHUD();
    }//end Start

    // Update is called once per frame
    void Update()
    {

            GetGameStats();
            SetHUD();

    }//end Update()

    void GetGameStats()
    {
        lives = gm.Lives;
        score = gm.Score;
        highscore = gm.HighScore;
        dispalyTime = LevelManager.displayTime;
        collectableAmount = LevelManager.collectAmount;
        collectablesCollected = LevelManager.collectablesCollected;
    }

    void SetHUD()
    {
        //if texbox exsists update value
        if (levelTextbox) { levelTextbox.text = "Level " + level + "/" + totalLevels; }
        if (livesTextbox) { livesTextbox.text = "Lives " + lives; }
        if (scoreTextbox) { scoreTextbox.text = "Score " + score; }
        if (highScoreTextbox) { highScoreTextbox.text = "High Score " + highscore; }
        if (timerTextbox) { timerTextbox.text = "Timer: " + dispalyTime; }
        if(collecteablesTextbox) { collecteablesTextbox.text = "Collected " + collectablesCollected + "/" + collectableAmount; }

    }//end SetHUD()

}
