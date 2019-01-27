// File Created by SChiraz 1/25/19 - ???
// File Edited by DanielO 1/26/19 - ???
// File Edited by SChiraz 1/26/19 - 8:00pm


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamera : MonoBehaviour {

    public Transform ThePlayer;
    public Vector3 OffSet;
    public float smoothSpeed = 0.125f;
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

        RaycastHit WallHit = new RaycastHit();

        if (Physics.Raycast(ThePlayer.transform.position, -(ThePlayer.transform.forward), out WallHit, 2.0f))
        {
            if (WallHit.transform.gameObject.tag == "Wall")
            {
                OffSet = new Vector3(0, 8, -4);
                transform.Rotate(Vector3.right, 20);
                smoothSpeed = 0.05f;
            }
            else
            {
                OffSet = new Vector3(0, 4, -4);
            }

            Debug.DrawLine(ThePlayer.transform.position, WallHit.transform.position);
        }



        //if (transform.position.x < -10 || transform.position.x > 3 || transform.position.z < -9 || transform.position.z > 12 && room == 1)
        //{

        //}
        //else
        //{

        //    //gameObject.transform.Translate(OffSet = new Vector3(0, 3, -3));

        //    //if (OffSet == new Vector3(0, 3, -3))
        //    //{
        //    //    smoothSpeed = 1f;
        //    //}
        //}
    }

    //private void OnTriggerEnter(Collider c)
    //{
    //    OffSet = new Vector3(0, 8, -4);
    //    transform.Rotate(Vector3.right, 20);
    //    smoothSpeed = 0.05f;
    //}

    //private void OnTriggerExit(Collider c)
    //{
    //    OffSet = new Vector3(0, 4, -4);
    //}
}
