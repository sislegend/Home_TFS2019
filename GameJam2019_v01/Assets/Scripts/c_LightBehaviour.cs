//CREATED BY K.ENNIS (Loui wuz here) 1/26/19 1:19AM
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_LightBehaviour : MonoBehaviour {
    
    public float l_Radius;
    public float l_RadiusMax = 12;
    public float l_Intensity;
    public bool radiusDecreasing;
    Light p_Candle;
    public GameObject[] shadow;
    public RaycastHit shadowRay;

    

    public int timesCoroutineCalled;

    void Start()
    {
        p_Candle = GetComponent<Light>();
        l_Intensity = p_Candle.spotAngle;
        l_Radius = p_Candle.range;
        radiusDecreasing = false;
        timesCoroutineCalled = 0;
    }

    void Update()
    {
        p_Candle.range = l_Radius;
        p_Candle.spotAngle = l_Intensity;

        if (radiusDecreasing)
        {
            l_Radius -= Time.deltaTime;
            GameObject.FindGameObjectWithTag("Actual Shadow").transform.localScale += new Vector3(.5f, -l_Radius, 0);
        }
        if (!radiusDecreasing)
        {
            if (l_Radius < l_RadiusMax)
            {
                l_Radius += Time.deltaTime;
            }
        }
        if(l_Radius <= 0)
        {
            p_Candle.intensity = 0;
            GameObject.FindGameObjectWithTag("flicker").SetActive(false);
           
        }
    }
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Shadow")
        {
            radiusDecreasing = true;
        }
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "Shadow")
        {
            radiusDecreasing = false;
        }
    }
}
