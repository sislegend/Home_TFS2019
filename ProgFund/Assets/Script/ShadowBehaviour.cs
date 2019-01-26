// File Created by LFtichar 19/01/2019
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowBehaviour : MonoBehaviour
{
    public GameObject target;
    public float reduction;


    private float lightDistance;
	// Use this for initialization
	void Start ()
    {
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.LookAt(target.transform);

    }

    private void FixedUpdate()
    {
        RaycastHit findLightDistance;
        Ray forwardRay = new Ray(transform.position, Vector3.forward);
        if (Physics.Raycast(forwardRay, out findLightDistance))
        {
            float lightDistance = findLightDistance.distance;
            
            if(lightDistance < target.GetComponent<c_LightBehaviour>().L_Radius())
            {
                //target.GetComponent<c_LightBehaviour>().L_Radius()
            }
        }
    }

    void FindDistance()
    {


    }



}
