// Created by SChiraz 01/26/19 - 2:07am
// Edited by SChiraz 01/26/19 - 3:49am
// Edited by KEnnis 01/26/19 - 1:04 pm
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMovement : MonoBehaviour {

    float PSpeed = 10.0f;
    float p_speedTMP;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            p_speedTMP = PSpeed;
            PSpeed = PSpeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PSpeed = p_speedTMP;
        }
	}

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * (Input.GetAxis("Vertical")/3) * PSpeed);

        var v3 = new Vector3(0, Input.GetAxis("Horizontal")*2, 0);
        transform.Rotate(v3 * 50 * Time.deltaTime);
    }
}
