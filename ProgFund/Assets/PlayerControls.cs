using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float forwardSpeed = 10;
    public float sidewaysSpeed = 5;
    public float jumpForce = 10;
    public float rotationSpeed = 1;
    public int positionCam = 1;

    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;

    public GameObject cam;

    

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Rotate();
        if (Input.GetKeyDown(KeyCode.E) && positionCam < 4)
        {
            positionCam++;
        }

        if (Input.GetKeyDown(KeyCode.Q) && positionCam > 1)
        {
            positionCam --;
        }

        if (positionCam == 1)
        {
            cam.transform.position = pos1.transform.position;
            cam.transform.rotation = Quaternion.AngleAxis(-180, Vector3.up);
        }
        if (positionCam == 2)
        {
            cam.transform.position = pos2.transform.position;
            cam.transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
        }
        if (positionCam == 3)
        {
            cam.transform.position = pos3.transform.position;
            cam.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }
        if (positionCam == 4)
        {
            cam.transform.position = pos4.transform.position;
            cam.transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        //GET HORIZONTAL MOVEMENT AND ADD THAT TO POSITION
   
        Vector3 horizontal = Input.GetAxis("Horizontal") * sidewaysSpeed * transform.right;
        //GET FORWARD MOVEMENT AND ADD THAT TO POSITION

        Vector3 forward = Input.GetAxis("Vertical") * forwardSpeed * transform.forward;

        rb.AddForce(horizontal + forward);
        //transform.position += horizontal + forward;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
        }
    }

    void Rotate()
    {
        float deltaRotation = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        Vector3 newLookAtDirection = transform.forward + deltaRotation * transform.right;
        Vector3 newLookAtPoint = transform.position + newLookAtDirection;
        transform.LookAt(newLookAtPoint);
    }

}
