// Created by SChiraz 01/26/19 - 2:07am
// Edited by SChiraz 01/26/19 - 3:49am

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour {

    float PSpeed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * PSpeed);

        var v3 = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate(v3 * 50 * Time.deltaTime);
    }
}
