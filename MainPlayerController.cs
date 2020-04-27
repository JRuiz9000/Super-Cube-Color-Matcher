using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class MainPlayerController : MonoBehaviour
{
    //Rigidbody rbCube; //Private variable to represent rigidbody

    //Vector3 torque; //Stores vector for force

    public float physForceX = 14.0f;
    public float physForceZ = 14.0f;
    
    // Start is called before the first frame update
    void Start()
    {
       //rbCube = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
       //torque = Vector3.zero;
     
       float torqueX = 0.0f;
  
       if (Input.GetKey(KeyCode.A))
       {
          torqueX -= (2 * physForceX);
       }
       else if (Input.GetKey(KeyCode.D))
       {
          torqueX += (2 * physForceX);
       }
       
       float torqueZ = 0.0f;

       if (Input.GetKey(KeyCode.W))
       {
          torqueZ += (2 * physForceZ);
       }
       else if (Input.GetKey(KeyCode.S))
       {
          torqueZ -= (2 * physForceZ);
       }  

       GetComponent<Rigidbody>().AddForce(torqueX, 0, torqueZ);
    }
 
    /* private void FixedUpdate()
    {
       rbCube.AddTorque(torque * 10.0f);
       rbCube.AddForce(transform.forward * 5.0f, ForceMode.Impulse);     
    }*/
}
