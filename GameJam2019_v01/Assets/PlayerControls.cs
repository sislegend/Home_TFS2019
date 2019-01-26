using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Make positionCam = 0, in inspector to use follow camera
//Make positionCam = 1, in inspector to use flip camera
public class PlayerControls : MonoBehaviour
{

    public float forwardSpeed = 10;
    public float sidewaysSpeed = 5;
    public float jumpForce = 10;
    public float rotationSpeed = 1;
    public int positionCam = 1;





    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("Keyboard works!");
        }

        Move();
        Jump();


    }

    private void FixedUpdate()
    {

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



}
