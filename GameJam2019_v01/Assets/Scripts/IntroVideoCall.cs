//created by Lilly 1/26/2019 11.33pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class IntroVideoCall : MonoBehaviour
{
    
    public int _videoLength;

    private float _videoPlayedTime;
    private bool _endVideo;

	// Use this for initialization
	void Start ()
    {
        _videoPlayedTime = 0;
        _endVideo = false;
        //will attach the video player to the main cam
        //GameObject camera = GameObject.Find("Main Camera");

        //videoplayer targets cam when it is added
        //var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();

        //play on awake defaults to true set to false
        //videoPlayer.playOnAwake = false;

        //by default video player add to a far plane setting it to near plane
        //videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;

        //this can adjust if you can see the scene behind the video being played
        //videoPlayer.targetCameraAlpha = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        _videoPlayedTime += Time.deltaTime;
        if (_videoPlayedTime > _videoLength)
        {
            _endVideo = true;
        }

        if (_endVideo)
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }
    }
}
