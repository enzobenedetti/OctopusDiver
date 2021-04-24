using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [HideInInspector]
    public static bool gamePaused = false;
    [HideInInspector]
    public static bool win = false;
    [HideInInspector]
    public static bool loose = false;
    [HideInInspector]
    public static bool gameDone = false;

    [SerializeField]
    private GameObject octopus;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause") && !loose && !win)
            gamePaused = !gamePaused;
        if (win || loose)
        {
            gameDone = true;
        }
    }

    public static void GameLost()
    {
        loose = true;
    }
    public static void GameWin()
    {
        win = true;
    }
}
