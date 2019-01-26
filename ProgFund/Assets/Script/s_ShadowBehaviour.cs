using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s_ShadowBehaviour : MonoBehaviour
{
    public GameObject c_CandleLight;
    public GameObject target;
    public float reduction;

    private bool s_Shrink;
    private float s_LightRadius;
    private float s_CountUp;


	// Use this for initialization
	void Start ()
    {
        s_Shrink = false;
        s_LightRadius = c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius();
    }
    private void OnTriggerEnter(Collider other)
    {
        s_Shrink = true;
    }
    // Update is called once per frame
    void Update ()
    {
        transform.LookAt(target.transform);
        s_LightRadius = c_CandleLight.GetComponent<c_LightBehaviour>().L_StartRadius();
        Grow();
	}

    void shrink()
    {
        if (s_Shrink)
        {
            s_CountUp += Time.deltaTime * reduction;
            s_LightRadius -= s_CountUp;
            c_CandleLight.GetComponent<c_LightBehaviour>().L_Radius(s_LightRadius);
        }
    }
    
    void Grow()
    {
        if(!s_Shrink)
        {

        }
    }
}
