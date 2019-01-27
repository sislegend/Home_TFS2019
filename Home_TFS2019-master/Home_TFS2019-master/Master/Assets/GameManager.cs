using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public enum GameState { play, pause, end }
    public GameState CurrentGState = GameState.play;

    public CMovement ThePlayer;

    public GameObject PauseUI;

    private static GameManager Instance;

    public static GameManager Get()
    {
        return Instance;
    }

    // Use this for initialization
    void Start()
    {
        if (Instance)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (CurrentGState == GameState.play)
            {
                CurrentGState = GameState.pause;
            }
            else if (CurrentGState == GameState.pause)
            {
                CurrentGState = GameState.play;
            }
        }

        switch (CurrentGState)
        {
            case GameState.play:
                Play();
                break;

            case GameState.pause:
                Pause();
                break;

            case GameState.end:
                End();
                break;
        }

    }

    void Play()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1;
    }

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0;
    }

    void End()
    {
        Time.timeScale = 0;
    }
}
