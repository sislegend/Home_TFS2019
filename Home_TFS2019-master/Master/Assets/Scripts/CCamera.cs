using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCamera : MonoBehaviour {

    public Transform ThePlayer;
    public Vector3 OffSet;

    // Use this for initialization
    void Start()
    {
        transform.Rotate(Vector3.up, 45);
        OffSet = new Vector3(0, 5, -5);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 NewPosition = ThePlayer.transform.position;

        NewPosition += OffSet.x * ThePlayer.right;
        NewPosition += OffSet.y * ThePlayer.up;
        NewPosition += OffSet.z * ThePlayer.forward;
        transform.position = NewPosition;
        transform.position = Vector3.Lerp(transform.position, NewPosition, 70 * Time.deltaTime);

        transform.LookAt(ThePlayer);

    }

}
