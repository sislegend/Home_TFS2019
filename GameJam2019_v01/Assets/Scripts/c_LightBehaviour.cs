//CREATED BY K.ENNIS (Loui wuz here) 1/26/19 1:19AM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class c_LightBehaviour : MonoBehaviour {
    
    public float l_Radius;
    public float l_RadiusMax = 12;
    public float l_Intensity;
    public bool radiusDecreasing;
    public bool radiusSlow;
    public bool hasTeddy;
    Light p_Candle;
    public GameObject[] shadow;

    public GameObject tryAgain;

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Intensity = p_Candle.spotAngle;
        l_Radius = p_Candle.range;
        radiusDecreasing = false;
        radiusSlow = false;
        hasTeddy = false;
    }

    void Update()
    {
        p_Candle.range = l_Radius;
        p_Candle.spotAngle = l_Intensity;
                
        if (radiusDecreasing && hasTeddy == false)
        {
            l_Radius -= 3.8f * Time.deltaTime;
        }

        if (radiusSlow && l_Radius >= 0.2 && hasTeddy == false)
        {
            l_Radius -= 2.5f * Time.deltaTime;
        }
        
        if (!radiusDecreasing && !radiusSlow)
        {
            if (l_Radius < l_RadiusMax)
            {
                l_Radius += Time.deltaTime;
            }
        }

        if(l_Radius <= 0)
        {
            p_Candle.intensity = 0;
            //GameObject.FindGameObjectWithTag("flicker").SetActive(false);
            //GameManager.CurrentGState = GameManager.GameState.end;
        }
    }
    
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Actual Shadow" && c.gameObject.name == "Final Shadow")
        {
            radiusSlow = true;
        }
        else if (c.gameObject.tag == "Actual Shadow" && c.gameObject.name != "Final Shadow")
        {
            radiusDecreasing = true;
        }

        if (c.gameObject.tag == "Teddy")
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            hasTeddy = true;
            l_RadiusMax *= 2;
            c.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Actual Shadow" && c.gameObject.name == "Final Shadow")
        {
            radiusSlow = false;
        }
        else if (c.gameObject.tag == "Actual Shadow" && c.gameObject.name != "Final Shadow")
        {
            radiusDecreasing = false;
        }
    }

}
