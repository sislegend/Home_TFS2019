using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    //public bool LightHit1 = false;
    //public bool LightHit2 = false;
    //public bool LightHit3 = false;

    public List<GameObject> Items = new List<GameObject>();
    //public GameObject[] Items;
    private bool[] isLit = new bool[2];

    //ShadowSpawn Shadows = new ShadowSpawn();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        for(int i = 0; i<isLit.Length;i++ )
        //foreach (GameObject Item in Items)
        {
            //RaycastHit hit;
            foreach (GameObject item in Items)
            {
                if (Physics.Raycast(item.transform.position, transform.position - item.transform.position, 5)) //Source.GetComponent<l_source>().lightRange) //checks to see if the raycast is within the light source radius 
                {

                    isLit[i] = true;

                    if ((isLit[0] == true && isLit[1] == false) || (isLit[0] == false && isLit[1] == true))
                    {
                        Items[i].GetComponent<ShadowSpawn>().setActive(true);
                    }
                    else
                    {
                        Items[i].GetComponent<ShadowSpawn>().setActive(false);
                    }

                }
            }
        }

        
		
	}
}
