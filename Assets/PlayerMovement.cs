using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityStandardAssets.CrossPlatformInput;


public class PlayerMovement : MonoBehaviour
{
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;

    public float speed;             //Floating point variable to store the player's movement speed.


    // Use this for initialization
    void Start()
    {
   }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (Input.GetKey(leftKey))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(rightKey))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(upKey))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(downKey))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }


        /*
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis(InputHorizontalName);
        
        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis(InputVericalName);

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
        */
    }
}