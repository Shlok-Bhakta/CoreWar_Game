using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandrandomizer : MonoBehaviour
{

    public float jankisland = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        //runs a method that contains the island randomization
        randommovement();
    }
    void randommovement()
    {

        //rotates island to a random y rotation
        Quaternion randomMotiom = Quaternion.Euler(jankisland, Random.Range(0, 360), 0);
        transform.rotation = randomMotiom;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
