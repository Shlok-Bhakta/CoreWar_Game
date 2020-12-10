using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityforCharCont : MonoBehaviour
{


    //duh...
    Vector3 Velocity;
    //how fast we fall
    public float GravityMultiplier = 9.81f;
    //getting the character controller used for movement in Character_Movement.cs
    public CharacterController playerCont;
    //setting a value for jump height
    public float jumpHeight = 3f;
    //checking for the ground - yeah.....
    public Transform groundCheckL;
    public Transform groundCheckR;
    //generating a spere around the ground checker to fix the gravity
    public float groundDist;
    //What objects the sphere should check for
    public LayerMask goundMask;
    //if we are touching the ground isGround == True
    bool isGroundL;
    bool isGroundR;

    void Start()
    {

    }


    void Update()
    {
        //will check if a "sphere" around the point intersects with the ground
        isGroundL = Physics.CheckSphere(groundCheckL.position, groundDist, goundMask);
        isGroundR = Physics.CheckSphere(groundCheckR.position, groundDist, goundMask);




        //adding the speed to velocity
        Velocity.y += (GravityMultiplier * (-1)) * (Time.deltaTime * Time.deltaTime);
        
        //applying the velocity in the downward direction
        playerCont.Move(Velocity);

        //jumping as well

        if (Input.GetButtonDown("Jump") && isGroundL)
        {
            //formula for gravity
            Velocity.y = jumpHeight;
        }

        if (isGroundL && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }
        if (isGroundR && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }



    }
}
