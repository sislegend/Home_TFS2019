//File Created by ATepylo 25/01/19 11:10

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShadowSpawn : MonoBehaviour {

    public List<GameObject> Items = new List<GameObject>();
    public List<GameObject> LightSource = new List<GameObject>();
    public GameObject Shadow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        foreach(GameObject Item in Items)
        {
            int shadowLights = 0;
            foreach(GameObject Source in LightSource)
            {
                //RaycastHit hit;
                if (Physics.Raycast(Item.transform.position, Source.transform.position - Item.transform.position, 5)) //Source.GetComponent<l_source>().lightRange) //checks to see if the raycast is within thelight source radius 
                {
                    if(shadowLights < 2)
                    {
                        //Vector3 spawnLocaction = -(Source.transform.position - Item.transform.position);
                        //new Vector3(Item.transform.position.x, Item.transform.position.y, Item.transform.position.z);
                        Shadow.transform.position = Item.transform.position - new Vector3(Item.transform.position.x - (Source.transform.position.x - Item.transform.position.x), Item.transform.position.y, Item.transform.position.z - (Source.transform.position.z - Item.transform.position.z));
                        Instantiate(Shadow, Shadow.transform);
                        shadowLights++;
                    }

                    if (shadowLights >= 2)
                    {
                        //Vector3 spawnLocaction = -(Source.transform.position - Item.transform.position);
                        //new Vector3(Item.transform.position.x, Item.transform.position.y, Item.transform.position.z);
                        //Shadow.transform.position = Item.transform.position - new Vector3(Item.transform.position.x - (Source.transform.position.x - Item.transform.position.x), Item.transform.position.y, Item.transform.position.z - (Source.transform.position.z - Item.transform.position.z));
                        //Instantiate(Shadow, Shadow.transform);
                        //shadowLights++;
                        Shadow.SetActive(false);
                    }


                    Shadow.transform.position = Item.transform.position - new Vector3(Item.transform.position.x - (Source.transform.position.x - Item.transform.position.x), Item.transform.position.y, Item.transform.position.z - (Source.transform.position.z - Item.transform.position.z));

                }



            }



        }


		
	}
}
