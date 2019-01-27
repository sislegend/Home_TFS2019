using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonFunctionality : MonoBehaviour
{
    Scene CurrentScene; 


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame


    public void Restart()
    {
        CurrentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(CurrentScene.buildIndex);
    }

    public void Quit()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void LoadCredits()
    {
        //SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}