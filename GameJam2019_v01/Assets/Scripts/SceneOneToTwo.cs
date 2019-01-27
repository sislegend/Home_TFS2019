//Created by Lilly 1/26/2019 9.20pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class SceneOneToTwo : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Tweet");
        if (collider.gameObject.tag == "Player" && !GameObject.FindGameObjectWithTag("Actual Shadow").active)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
            gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
        }
    }
}
