using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int currentScore;
    public int highScore;

    public int currentLevel = 50;
    public int unlockedLevel;

    public Rect timerRect;

    public Color warningColorTimer;
    public Color normalColorTimer;

    public GUISkin skin;

    private float startTime;
    private string currentTime;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);//that method do not destroy GameMasnager at next scene
    }

    private void Update()
    {
        startTime -= Time.deltaTime;
        currentTime = string.Format("{0:0.0}", startTime);

        if (startTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void CompleteLevel()
    {
        currentLevel ++;
        print("Congratulations ! Try to complite next level !");
        SceneManager.LoadScene(currentLevel);
    }

    private void OnGUI()
    {
        GUI.skin = skin;
        if (startTime>5f)
        {
            skin.GetStyle("Timer").normal.textColor = warningColorTimer;
        }
        else
        {
            GUI.Label(timerRect, currentTime, skin.GetStyle("Timer"));
        }
        
    }
}
