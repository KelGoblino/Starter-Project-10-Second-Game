using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string sceneName;

    //change to scene when time is up or a button is clicked
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    //quits the game
    public void doExitGame()
    {
        Application.Quit();
    }

}
