// Created by SChiraz 1/26/19 - 12:29am
//Edited by KEnnis 1/26/19 - 1:04pm
//Edited by lilly 1/26/2019 - 9:00pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MMenu : MonoBehaviour
{
    float angle;


    //private int m_SceneSelection;

    private void Start()
    {
        //m_SceneSelection = 0;
    }

    public void ChangeToNextScene()
    {
        // Input Fade + Sound
        //m_SceneSelection += 1;

        SceneManager.LoadScene(1, LoadSceneMode.Single);
        //gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
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
