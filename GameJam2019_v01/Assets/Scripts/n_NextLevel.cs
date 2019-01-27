//Created by Lilly 1/27/2019 3.46pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class n_NextLevel : MonoBehaviour
{
    public GameObject n_canMoveForward;
    public int n_nextLevel;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Tweet");
        if (collider.gameObject.tag == "Player" && n_canMoveForward.GetComponent<c_StaticLightBehaviour>().lightON)
        {
            SceneManager.LoadScene(n_nextLevel, LoadSceneMode.Single);
            //gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
        }
    }
}
