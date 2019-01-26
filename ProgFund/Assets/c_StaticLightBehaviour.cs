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

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Radius = p_Candle.range;
        p_Candle.range = 50;
        p_Candle.intensity = 0;
    }

    void Update()
    {

        if (lightON == true)
        {
            pulse.SetActive(true);
            pulse2.SetActive(true);
            p_Candle.range -=Time.deltaTime;
            time += Time.deltaTime;
            p_Candle.intensity = 1;
        }
       
        if(time >= 15)
        {
            pulse.SetActive(false);
            pulse2.SetActive(false);
            p_Candle.intensity = 0;
            time = 0;
            lightON = false;
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
