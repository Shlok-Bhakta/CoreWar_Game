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
    public CharacterController playercont;




    void Start()
    {
        
    }


    void Update()
    {
        //adding the speed to velocity
        Velocity.y += (GravityMultiplier * (-1)) * (Time.deltaTime * Time.deltaTime);
        
        //applying the velocity in the downward direction
        playercont.Move(Velocity);
    
    
    }
}
