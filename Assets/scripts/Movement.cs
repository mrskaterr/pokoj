using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode Up;
    [SerializeField] KeyCode Down;
    [SerializeField] KeyCode Right;
    [SerializeField] KeyCode Left;
    [SerializeField] float Speed;
    [SerializeField] float Magnitude;
    Rigidbody rb;

   void Start()
   {
       rb=GetComponent<Rigidbody>();
   }
    void FixedUpdate()
    {
        if(Input.GetKey(Up))
            rb.AddForce(Vector3.forward*Speed,ForceMode.Force);
            
        if(Input.GetKey(Down))
            rb.AddForce(-Vector3.forward*Speed,ForceMode.Force);
            
        if(Input.GetKey(Right))
            rb.AddForce(Vector3.right*Speed,ForceMode.Force);

        if(Input.GetKey(Left))
            rb.AddForce(Vector3.left*Speed,ForceMode.Force);
        
        if(rb.velocity.magnitude>Magnitude)
            rb.velocity=new Vector3(
                                    Mathf.Clamp(rb.velocity.x,0,Magnitude),
                                    Mathf.Clamp(rb.velocity.y,0,Magnitude),
                                    Mathf.Clamp(rb.velocity.z,0,Magnitude))    ;
    }
}
