using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHud : MonoBehaviour {

    public int ItemAmount = 0;

    public TextMesh text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (ItemAmount == 1)
        text.text = "hello";
        

	}
}
