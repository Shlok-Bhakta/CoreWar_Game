//thanks again brakeys https://www.youtube.com/watch?v=_QajrabyTJc

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Movement : MonoBehaviour
{


    //some other variables
    public CharacterController Controller;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //creating variables for getting movement on an axis
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //creating a vector3 for movement
        Vector3 move = (transform.right * x) + (transform.forward * z);
        
        //applying the movement
        Controller.Move(move * speed * Time.deltaTime);

    }
}
