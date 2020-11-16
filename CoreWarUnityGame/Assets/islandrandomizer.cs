using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandrandomizer : MonoBehaviour
{

    public float jankisland = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        
        
        
        
        randommovement();
    }
    void randommovement()
    {

        
        Quaternion randomMotiom = Quaternion.Euler(jankisland, Random.Range(0, 360), 0);
        transform.rotation = randomMotiom;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
