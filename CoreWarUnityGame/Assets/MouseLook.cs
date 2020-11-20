//https://www.youtube.com/watch?v=_QajrabyTJc thanks Brackeys for teaching me


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{   //creating a float to change the sensitivity
    public float sensitivity = 300f;

    //creating a float for the player body
    public Transform playerBody;
<<<<<<< HEAD

    public Transform Cam;


=======
    
>>>>>>> parent of 07c3a2e... added movement and gravity is jank
    //creating a float for a camera
    float xRotation = 90;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
<<<<<<< HEAD

        //Cam.Rotate(0f, -90f, f);


=======
>>>>>>> parent of 07c3a2e... added movement and gravity is jank
    }
 
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
        xRotation = Mathf.Clamp(xRotation, 0f, 180f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        //getting movement of camera X axis
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
