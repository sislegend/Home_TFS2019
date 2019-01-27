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

    bool IsHit = false;

    Vector3 WallPos;


    // Use this for initialization
    void Start()
    {
        //transform.Rotate(Vector3.up, 180);
        OffSet = new Vector3(0, 9.8f, 0);
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

        if (IsHit) { Offset();  } else { OffSet = new Vector3(0, 5, -7); }

        //Edited by Daniel O.

        //RaycastHit WallHit = new RaycastHit();

        //if (Physics.Raycast(ThePlayer.transform.position, -(ThePlayer.transform.forward), out WallHit, 2.0f))
        //{
        //    Debug.Log(WallHit.transform.gameObject.tag);
        //    if (WallHit.transform.gameObject.tag == "Wall" && WallHit.transform.gameObject.tag != null)
        //    {
        //        OffSet = new Vector3(0, 8, -4);
        //        transform.Rotate(Vector3.right, 20);
        //        smoothSpeed = 0.05f;
        //    }
        //    else
        //    {
        //        OffSet = new Vector3(0, 4, -4);
        //    }

        //    Debug.DrawLine(ThePlayer.transform.position, WallHit.transform.position);
        //}



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


    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "AWall")
        {
            WallPos = c.gameObject.transform.position;
            IsHit = true;
        } 
    }

    private void OnTriggerExit(Collider c)
    {
        IsHit = false;
    }


    void Offset()
    {
        if (OffSet.y != 10) { OffSet = new Vector3(0, 10, -12); }
        transform.Rotate(Vector3.right, 20);
        smoothSpeed = 0.05f;

        float Dist = (WallPos - transform.position).magnitude;
        if(Dist < 0) { Dist = -Dist; }

        if (OffSet.y == 10)
        {
            Debug.Log(Dist);
            if (Dist > 13)
            {
                OffSet.z += .5f;
            }
        }
    }
}
