using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour {

    public List<GameObject> Lights = new List<GameObject>();
    public List<GameObject> SPoints = new List<GameObject>();
    public bool Islit = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject TheShadow in SPoints)
        {
            for (int cpt = 0; cpt < Lights.Count; ++cpt)
            {
                if (Physics.Raycast(Lights[cpt].transform.position, TheShadow.transform.position - Lights[cpt].transform.position, 5)) //Source.GetComponent<l_source>().lightRange) //checks to see if the raycast is within the light source radius 
                {

                    Islit = true;
                }
                else
                {
                    Islit = false;
                }
            }
        }
    }
}
