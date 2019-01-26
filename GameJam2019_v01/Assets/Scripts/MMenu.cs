// Created by SChiraz 1/26/19 - 12:29am

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMenu : MonoBehaviour {

    public void Load()
    {
        // Input Fade + Sound
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public  void Quit()
    {
        // Check GameState
        Application.Quit();
    }
}
