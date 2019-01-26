using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject shadow;
    
    

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Animator>().Play("idle");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Candle")
        {
            SpawnShadow();
            gameObject.GetComponent<Animator>().Play("rockingHorse");
        }
    }

    private void OnTriggerExit(Collider c) 
    {
        if (c.gameObject.tag == "Candle")
        {
            gameObject.GetComponent<Animator>().Play("idle");
        }
    }
    public void SpawnShadow()
    {  
        Instantiate(shadow, spawnPoint.transform.position, Quaternion.identity);
    }
}
