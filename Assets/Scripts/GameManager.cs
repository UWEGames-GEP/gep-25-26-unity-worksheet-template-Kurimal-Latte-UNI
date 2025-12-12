using System;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    [Serializable]
    public enum GameState {GAMEPLAY,PAUSE}
    [SerializeField]
    public GameState state = GameState.GAMEPLAY;
    bool StateChanged = false;

    public GameObject InventoryUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameState state = GameState.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == GameState.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("It been clicked and paused");
                state = GameState.PAUSE;
                StateChanged = true;
                InventoryUI.SetActive(true);
            }
        }
        else if (state == GameState.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("It been clicked and unpaused");
                state = GameState.GAMEPLAY;
                StateChanged = true;
                InventoryUI.SetActive(false);

            }
        }


    }

   
    private void LateUpdate()
    {
        if (StateChanged)
        {
            // Toggle StateChanged
            StateChanged = false;
            Debug.Log("state changed");
            if (state == GameState.GAMEPLAY)
            {
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else if (state == GameState.PAUSE)
            {
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}

