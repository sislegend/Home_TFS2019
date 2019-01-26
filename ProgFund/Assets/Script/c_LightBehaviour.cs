//CREATED BY K.ENNIS 1/26/19 1:19AM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_LightBehaviour : MonoBehaviour {

 
    private float l_Radius;
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

    public float L_Radius()
    {
        return l_Radius;
    }

    public void L_Radius(float change)
    {
        l_Radius = change;
    }
}
