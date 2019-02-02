//Created by Lilly 1/27/2019 3.46pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class n_NextLevel : MonoBehaviour
{
    public GameObject n_canMoveForward;
    private int sceneNumber;
    private void Start()
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
    }
    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Tweet");
        if (c.gameObject.tag == "Player" && n_canMoveForward.GetComponent<c_StaticLightBehaviour>().lightON)
        {
            SceneManager.LoadScene(sceneNumber+=1, LoadSceneMode.Single);
            if (sceneNumber == 1)
            {
                Debug.Log("title unloaded");
                SceneManager.UnloadSceneAsync(0);
                Resources.UnloadUnusedAssets();
                Debug.Log("title assets unloaded");
            }
            if (sceneNumber == 2)
            {
                Debug.Log("Level 1 unloaded");
                SceneManager.UnloadSceneAsync(1);
                Debug.Log("Level 1 Assets unloaded");
            }
            if (sceneNumber == 3)
            {
                Debug.Log("Level 2 unloaded");
                SceneManager.UnloadSceneAsync(2);
                Debug.Log("Level 2 unloaded");
            }
            if (sceneNumber == 4)
            {
                Debug.Log("Level 3 unloaded");
                SceneManager.UnloadSceneAsync(3);
                Debug.Log("Level 3 assets unloaded");
            }
            if (sceneNumber == 5)
            {
                SceneManager.UnloadSceneAsync(4);
            }
            if (sceneNumber == 6)
            {
                SceneManager.UnloadSceneAsync(5);
            }
            //gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
        }
    }
}
