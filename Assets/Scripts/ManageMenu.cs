using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMenu : MonoBehaviour
{
    public GUISkin skin;
    private void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(10, 10, 400, 450), "Cube's adventure");

        if (GUI.Button(new Rect(10, 70, 300, 40), "Start"))
        {
            GameManager.CompleteLevel();
        }

        if (GUI.Button(new Rect(10, 120, 300, 45), "Quit"))
        {
            Application.Quit();
        }

    }
}
