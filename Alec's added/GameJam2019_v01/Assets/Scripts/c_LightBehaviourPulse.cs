using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_LightBehaviourPulse : MonoBehaviour {


    public float l_Radius;
    public float l_Intensity;
    Light p_Candle;

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Intensity = p_Candle.intensity;
        l_Radius = p_Candle.range;
    }

    void Update()
    {
        Random.Range(.042f, 1.34f);
        p_Candle.range = l_Radius;
        p_Candle.intensity = l_Intensity;
        var amplitude = Mathf.PingPong(Time.time, 4);

        amplitude = amplitude / 2 * 0.5f + 0.5f;
        p_Candle.intensity = l_Intensity * amplitude;
    }
}
