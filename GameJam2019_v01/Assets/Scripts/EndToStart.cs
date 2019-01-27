using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndToStart : MonoBehaviour
{

    //public GameObject n_canMoveForward;
    public int n_nextLevel;
    private float moveOnTimer;
    public int maxtime;

            //SceneManager.LoadScene(n_nextLevel, LoadSceneMode.Single);
            //gameObject.GetComponent<c_LightBehaviour>().tryAgain.SetActive(false);
        
    void Update()
    {
        moveOnTimer += Time.deltaTime;
        if (moveOnTimer > maxtime)
        {
            SceneManager.LoadScene(n_nextLevel, LoadSceneMode.Single);
        }
    }
}
