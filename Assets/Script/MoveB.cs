using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveB : MonoBehaviour
{
    public float MoveSpeed = 1;
    public float RotateSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveSpeed * Time.deltaTime, 0, 0, Space.World);
        transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
    }
}
