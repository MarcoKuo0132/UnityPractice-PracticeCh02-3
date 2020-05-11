using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("press key A");
        }
        if (Input.GetKey(KeyCode.A))
        {
            print("hold key A");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            print("release key A");
        }
        if (Input.GetAxis("Run")!=0)
        {
            print("control Run axis value=" + Input.GetAxis("Run"));
        }
    }
}
