﻿//https://www.youtube.com/watch?v=_QajrabyTJc thanks Brackeys for teaching me

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook2 : MonoBehaviour
{
    //creating a float to change the sensitivity
    public float sensitivity = 300f;



    //creating a float for the player body
    public Transform playerBody;

    public Transform cam;

    //creating a float for a camera
    float xRotation = 0;


    // Start is called before the first frame update
    void Start()
    {
        cam.Rotate(0f, 0f, 0f);
        
        Cursor.lockState = CursorLockMode.Locked;



    }

    // Update is called once per frame
    void Update()
    {
        //getting inputs for my mouse movement in the x and y axis
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        //applying sensitivity to the mouse movements and making it not move based on frame rate of the monitor
        mouseX = mouseX * sensitivity * Time.deltaTime;
        mouseY = mouseY * sensitivity * Time.deltaTime;





        //getting camera movement on the y axis
        xRotation -= mouseY;

        // clamping the camera so it doesnt spin to far
        xRotation = Mathf.Clamp(xRotation, -90f, 53f);

        transform.localRotation = Quaternion.Euler(0f, 0f, xRotation);

        //getting movement of camera X axis
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
