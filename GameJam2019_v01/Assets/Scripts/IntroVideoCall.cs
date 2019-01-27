//created by Lilly 1/26/2019 11.33pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntroVideoCall : MonoBehaviour
{
    
    public int n_videoLength;
    public int n_NextScene;

    private float n_videoPlayedTime;
    private bool n_endVideo;

	// Use this for initialization
	void Start ()
    {
        n_videoPlayedTime = 0;
        n_endVideo = false;
    }

    // Update is called once per frame
    void Update()
    {
        n_videoPlayedTime += Time.deltaTime;
        if (n_videoPlayedTime > n_videoLength)
        {
            n_endVideo = true;
        }

        if (n_endVideo)
        {
            SceneManager.LoadScene(n_NextScene, LoadSceneMode.Single);
        }
    }
}
