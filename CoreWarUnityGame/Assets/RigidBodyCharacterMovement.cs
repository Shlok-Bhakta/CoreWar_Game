using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacterMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody character;
    public Transform groundL;
    public Transform groundR;
    public float jumpForce = 4f;
    Vector3 move;

    
    
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {


        move = new Vector3(Input.GetAxis("Horizontal"), character.velocity.y, Input.GetAxis("Vertical"));

        character.velocity = move;
        /*if (Input.GetButtonDown("Jump") && (groundL || groundR) == true)
        {
            character.velocity = new Vector3(0f, character.velocity.y + jumpForce, 0f);
        }
        if (Input.GetButtonDown("Jump") && (groundL || groundR) == false)
        {
            print("your code is broken");
        }
        */
    }
        

    }

