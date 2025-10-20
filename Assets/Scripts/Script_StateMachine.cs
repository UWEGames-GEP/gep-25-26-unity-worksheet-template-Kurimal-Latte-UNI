using System;
using UnityEngine;
using UnityEngine.Android;

public class GameManager : MonoBehaviour
{

    [Serializable]
    enum GameState {GAMEPLAY,PAUSE}
    [SerializeField]
    GameState state = GameState.GAMEPLAY;
    bool StateChanged = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.PAUSE;
                StateChanged = true;
            }
        }
        else if (state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                state = GameState.GAMEPLAY;
                StateChanged = true;
            }
        }
    }
    private void LateUpdate()
    {
        if (StateChanged)
        {
            // Toggle StateChanged
            StateChanged = false;

            if (state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1.0f;
            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;
            }
        }
    }
}

