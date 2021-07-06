using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    //[SerializeField]
   // private Rigidbody rb;

    public float speed = 10.0f;
    public float jumpForce = 300.0f;
    public bool allowDoubleJump = false;
    private int amountOfJumps = 0;
    private float translation;
    private float strafe;
    public float maxGroundDistance = 1.5f;
    private bool isGrounded;

    //public float maxSpeed = 10f;
   


    // Start is called before the first frame update
    public void Start()
    {
     
    }

    public void LateUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, maxGroundDistance);
        if (isGrounded == true)
        {
            amountOfJumps = 0;
        }
    }

    // Update is called once per frame
    public void Update()
    {
       ////if(Input.GetKey(KeyCode.W))
       //{
       //    rb.AddForce(transform.forward * speed);
       //}

       // if (Input.GetKey(KeyCode.S))
       // {
       //     rb.AddForce(-transform.forward * speed);
       // }

       // if (Input.GetKey(KeyCode.A))
       // {
       //     rb.AddForce(-transform.right * speed);
       // }

       // if (Input.GetKey(KeyCode.D))
       // {
       //     rb.AddForce(transform.right * speed);
       // }

       // if(rb.velocity.magnitude > maxSpeed)
       // {
       //    rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
       // //}


       //Input.GetAxis() is used to get the user's input
       //You can furthor set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        strafe = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(strafe, 0, translation);

        
        if (Input.GetKeyDown("space"))
        {
            if (isGrounded)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
                amountOfJumps = 1;
            }
            else if(amountOfJumps < 2 && allowDoubleJump)
            {
                GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, jumpForce, 0.0f));
                amountOfJumps = 2;
            }

            
        }

    }
}
