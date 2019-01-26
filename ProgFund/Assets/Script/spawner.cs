using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;

    public int itemchoice;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.G))
        {
            itemchoice = Random.Range(1, 5);
        }

        if (Input.GetKeyDown(KeyCode.G) && itemchoice == 1)
        {
            Instantiate(item1, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.G) && itemchoice == 2)
        {
            Instantiate(item2, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.G) && itemchoice == 3)
        {
            Instantiate(item3, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.G) && itemchoice == 3)
        {
            try
            {
                Instantiate(item4, transform);
            }
            catch
            {
                Instantiate(item3, transform);
                Debug.Log("Error, No item 4");
            }

        }
    }
}
