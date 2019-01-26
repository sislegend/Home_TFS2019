// File Created by LFtichar 19/01/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBehaviour : MonoBehaviour
{

    public GameObject c_CandleLight;
    public GameObject target;
    public float reduction;


    private LayerMask layerMask;
    public RaycastHit findLightDistance;
    private float s_Radius;  //radius of light
    //private float s_LightDistance;
    private float s_LightRadius;
    private float countUp;
	// Use this for initialization
	void Start ()
    {
        s_Radius = 
        countUp = 0;
        //s_Radius = target.GetComponent<c_LightBehaviour>().L_StartRadius();
        layerMask = 9;
    }
	
	// Update is called once per frame
	//void Update ()
 //   {
 //       transform.LookAt(target.transform);
 //       s_LightRadius = c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius();
 //   }

    void Update()
    {

        transform.LookAt(target.transform);
        s_LightRadius = c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius();
        //Debug.Log(s_LightRadius + "Deep");
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out findLightDistance, /*Mathf.Infinity*/ 10, layerMask))
        {
            countUp += Time.deltaTime * reduction;
            Debug.Log(countUp);
            s_LightRadius -= countUp;
            //Debug.Log(s_Radius + "Trail");
            Debug.Log("agfhgdfhdfh df");

            //Debug.Log(s_LightDistance + "check");
            //if (s_LightDistance < (s_LightRadius / 5))
            //{
            //Debug.Log(s_Radius + "creep");
            c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_LightRadius);
        }
        else
        {
            if (c_CandleLight.GetComponent<c_LightBehaviour>().l_Radius < c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius())
            {
                countUp = 0;
                //countUp -= Time.deltaTime * reduction;
                Debug.Log(countUp);
                s_LightRadius += Time.deltaTime * reduction;
                //Debug.Log(s_Radius + "Trail");
                //Debug.Log("agfhgdfhdfh df");

                //Debug.Log(s_LightDistance + "check");
                //if (s_LightDistance < (s_LightRadius / 5))
                //{
                //Debug.Log(s_Radius + "creep");
                c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_LightRadius);
            }
            //if ( s_Radius < c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius())
            //{
            //    c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_Radius + 0.5f);
            //}
            //c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_Radius + 0.5f);
        }
        //Ray forwardRay = new Ray(transform.position, Vector3.forward);

    }
    //void Foo()
    //{
    //    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out findLightDistance, /*Mathf.Infinity*/ 10, layerMask))
    //    {
    //        //Debug.Log("agfhgdfhdfh df");

    //        //Debug.Log(s_LightDistance + "check");
    //        //if (s_LightDistance < (s_LightRadius / 5))
    //        //{
    //        Debug.Log(s_Radius + "creep");
    //        c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_Radius  Time.deltaTime);
    //    }
    //    else
    //    {
    //        //if ( s_Radius < c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius())
    //        //{
    //        //    c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_Radius + 0.5f);
    //        //}
    //        //c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_Radius + 0.5f);
    //    }
    //}

    //void FindDistance()
    //{


    //}



}
