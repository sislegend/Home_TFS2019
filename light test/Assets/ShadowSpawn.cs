//File Created by ATepylo 25/01/19 11:10

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShadowSpawn : MonoBehaviour {

    public bool isLit = false;
    //public bool isLit1 = false;

    //public bool isGone = false;

    //public List<GameObject> LightSource = new List<GameObject>();
    public GameObject Shadow;
    //private List<GameObject> inRange = new List<GameObject>();
    //int shadowLights = 0;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        checkShadows();
        


    }
void checkShadows()
    {
        if (isLit)
        {
            Shadow.SetActive(true);
        }
        else if( isLit==false)
        {
            Shadow.SetActive(false);
        }



        //else if (isLit == false)
        //{
        //    Shadow.SetActive(false);
        //}
        //else if(isGone)
        //{
        //    Debug.Log("GOt here");
        //    Shadow.SetActive(false);
        //}
    }

    public void setActive(bool set)
    {
        isLit = true;
    }
    
    //public void destroyShadow()
    //{
    //    isGone = true;
    //}


}
