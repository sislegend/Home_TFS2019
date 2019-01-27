using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_StaticLightBehaviour : MonoBehaviour {

    public float time = 30;
    public float l_Radius;
    public bool lightON;
    Light p_Candle;
    public GameObject pulse;
    public GameObject pulse2;
    public GameObject[] lightSources;
    public GameObject[] shadows;
    public bool levelEnd;

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Radius = p_Candle.range;
        p_Candle.range = 50;
        p_Candle.intensity = 0;
        levelEnd = false;
        if(shadows[2])
        {
            shadows[2].SetActive(false);
            shadows[3].SetActive(false);
        }

    }

    void Update()
    {
        if(lightON == true)
        {
            pulse.SetActive(true);
            pulse2.SetActive(true);
            p_Candle.range -= Time.deltaTime;
            time += Time.deltaTime;
            p_Candle.intensity = 3.8f;
        }
                     
        if (lightSources.Length == 1)
        {
            if (lightSources[0].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                
                GameObject.FindGameObjectWithTag("Actual Shadow").SetActive(false);
                levelEnd = true;
            }
        } 
        else if (lightSources.Length == 2)
        {
            if (lightSources[0].GetComponent<c_StaticLightBehaviour>().lightON == true && lightSources[1].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                GameObject.FindGameObjectWithTag("Actual Shadow").SetActive(false);
                levelEnd = true;
            }
        }
        else if(lightSources.Length == 4)
        {            
            if (lightSources[0].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                shadows[0].SetActive(false);
            }
            if (lightSources[1].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                //shadows[1].SetActive(false);
                shadows[2].SetActive(true);
                shadows[3].SetActive(true);
            }
            if (lightSources[1].GetComponent<c_StaticLightBehaviour>().lightON == true && lightSources[0].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                shadows[1].SetActive(false);
            }
            if(lightSources[1].GetComponent<c_StaticLightBehaviour>().lightON == true && lightSources[2].GetComponent<c_StaticLightBehaviour>().lightON == true)
            {
                shadows[2].SetActive(false);
                levelEnd = true;
            }

        }
        
        if (time >= 15)
        {
            pulse.SetActive(false);
            pulse2.SetActive(false);
            p_Candle.intensity = 0;
            time = 0;
            lightON = false;
            GameObject.FindGameObjectWithTag("Actual Shadow").SetActive(true);
        }
    }


    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {
            lightON = true;  
        }
    }
}
