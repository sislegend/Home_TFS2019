//File Created by ATepylo 25/01/19 11:10

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShadowSpawn : MonoBehaviour {

    public List<GameObject> SPoints = new List<GameObject>();

    public int NbrLights = -1;
    //public bool isLit1 = false;

    //public bool isGone = false;

    //public List<GameObject> LightSource = new List<GameObject>();
    public GameObject Shadow;
    //private List<GameObject> inRange = new List<GameObject>();
    //int shadowLights = 0;
	// Use this for initialization


        GameObject[] AH = new GameObject();

    void Start () {

        gameObject.AddComponent<Light>();

    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(gameObject.GetComponent<Light>().Lights.Count);
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("ah"); i++)
        //foreach (GameObject Item in Items)
        {
            Debug.Log(gameObject.GetComponent<Light>().Islit);

            if (gameObject.GetComponent<Light>().Islit) //Source.GetComponent<l_source>().lightRange) //checks to see if the raycast is within the light source radius 
            {

                NbrLights += 1;
            }
        }
        Debug.Log("=================================================================================================");
        checkShadows();     
    }
void checkShadows()
    {
        if (NbrLights == 1)
        {
            Shadow.SetActive(true);
        }
        else
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

    //public void setActive(bool set)
    //{
    //    isLit = true;
    //}
    
    //public void destroyShadow()
    //{
    //    isGone = true;
    //}


}
