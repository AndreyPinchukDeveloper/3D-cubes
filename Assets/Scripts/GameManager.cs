using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentScore;
    public static int highScore;

    public static int currentLevel = 0;
    public static int unlockedLevel;
     
    public static void CompleteLevel()
    {
        currentLevel ++;
        print("Congratulations ! Try to complite next level !");
        SceneManager.LoadScene(currentLevel);
    }
}
