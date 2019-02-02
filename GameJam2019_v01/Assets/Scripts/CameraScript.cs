using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public bool lockCursor;
    public float mousesensitivity = 10;
    public Transform target;
    public float distFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationsmoothTime = .12f;
    Vector3 rotationsmoothVelocity;
    Vector3 currentRotation;

    float yaw;
    float pitch;

    // Use this for initialization
	void Start ()
    {
		if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
	}

    private void LateUpdate()
    {
        yaw += Input.GetAxis("Mouse X") * mousesensitivity;
        pitch -= Input.GetAxis("Mouse Y") * mousesensitivity;
        pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationsmoothVelocity, rotationsmoothTime);
        transform.eulerAngles = currentRotation;

        Vector3 eul = transform.eulerAngles;
        eul.x = 0;

        target.eulerAngles = eul;
        transform.position = target.position - transform.forward * distFromTarget;
    }
}
