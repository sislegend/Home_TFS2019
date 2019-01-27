// Created by SChiraz 1/26/19 - 12:29am
//Edited by KEnnis 1/26/19 - 1:04pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMenu : MonoBehaviour {
    float angle;
    public void Load()
    {
        // Input Fade + Sound
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
    }
    public void ResetScene()
    {
        SceneManager.LoadScene("Main_Scene", LoadSceneMode.Single);
        gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
    }
    public  void Quit()
    {
        
        // Check GameState
        Application.Quit();
        Debug.Log("QUITTING");
    }
}
