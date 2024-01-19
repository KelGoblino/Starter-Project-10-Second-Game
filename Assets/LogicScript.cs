using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public LevelManager level;
    public float timeRemaining = 10;
    public int timeDisplay;
    public Text scoreText;

    void Start()
    {
        level = GameObject.FindGameObjectWithTag("Level").GetComponent<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timeDisplay = (int)timeRemaining;
            showTime();
        }
        if (timeRemaining <= 0)
        {
            level.changeScene();
        }

    }


    public void showTime()
    {
        scoreText.text = timeDisplay.ToString();
    }
}
