//CREATED BY K.ENNIS 1/26/19 1:19AM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_LightBehaviour : MonoBehaviour {

 
    public float l_Radius;
    Light p_Candle;
    private float l_StartRadius;

    void Start()
    {
     
        p_Candle = GetComponent<Light>();
        l_Radius = p_Candle.spotAngle;
        l_StartRadius = l_Radius;
        //Debug.Log(l_Radius + "temp");
    }

    void Update()
    {
        p_Candle.spotAngle = l_Radius;
    }

    public float L_StartRadius()
    {
        //Debug.Log(l_StartRadius +"tweet");
        return l_StartRadius;
    }

    public void L_Radius(float change)
    {
        l_Radius = change;
    }
}
