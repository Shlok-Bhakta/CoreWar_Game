using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class islandrandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        randommovement();
    }
    void randommovement()
    {
       Quaternion randomMotiom = Quaternion.Euler(-90, 0, Random.Range(-180 , 180));

        transform.rotation = randomMotiom;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
