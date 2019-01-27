//CREATED BY K.ENNIS 1/26/19 1:19AM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_LightBehaviour : MonoBehaviour {

 
    public float l_Radius;
    Light p_Candle;

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Radius = p_Candle.range;
    }

    void Update()
    {
        p_Candle.range = l_Radius;
    }
}
