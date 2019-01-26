using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamera : MonoBehaviour {

    public Transform ThePlayer;
    public Vector3 OffSet;
    public float smoothSpeed = 0.125f;
    public GameObject cam;
    public int room = 1;


    // Use this for initialization
    void Start()
    {
        transform.Rotate(Vector3.up, 45);
        OffSet = new Vector3(0, 4, -4);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 NewPosition = ThePlayer.transform.position;

        NewPosition += OffSet.x * ThePlayer.right;
        NewPosition += OffSet.y * ThePlayer.up;
        NewPosition += OffSet.z * ThePlayer.forward;
        transform.position = Vector3.Lerp(transform.position, NewPosition, smoothSpeed);

        transform.LookAt(ThePlayer);

        //Edited by Daniel O.

        if (transform.position.x < -10 || transform.position.x > 3 || transform.position.z < -9 || transform.position.z > 12 && room == 1)
        {
            OffSet = new Vector3(0, 8, -4);
            transform.Rotate(Vector3.right, 20);
            smoothSpeed = 0.05f;
        }
        else
        {
            OffSet = new Vector3(0, 4, -4);
            //gameObject.transform.Translate(OffSet = new Vector3(0, 3, -3));

            //if (OffSet == new Vector3(0, 3, -3))
            //{
            //    smoothSpeed = 1f;
            //}
        }




    }


}
