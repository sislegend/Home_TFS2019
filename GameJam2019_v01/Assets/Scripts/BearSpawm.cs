//CREATED SChiraz 1/27/19 3:39AM

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSpawm : MonoBehaviour {

    public GameObject MrPickles;
    public GameObject[] sp_Bear;

	// Use this for initialization
	void Start () {

        int randomIndex = UnityEngine.Random.Range(0, sp_Bear.Length);
        Instantiate(MrPickles, sp_Bear[randomIndex].transform);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
