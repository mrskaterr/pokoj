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
    [SerializeField] private float rotSpeed = 2;
    Rigidbody rb;

   void Start()
   {
        rb = GetComponent<Rigidbody>();
   }
    void FixedUpdate()
    {
        if(Input.GetKey(Up))
        {
            rb.AddForce(transform.forward * Speed, ForceMode.Force);
            //transform.eulerAngles = Vector3.up * 0;

        }
        if(Input.GetKey(Down))
        {
            rb.AddForce(-transform.forward * Speed, ForceMode.Force);
            //transform.eulerAngles = Vector3.up * 180;
        }
        if(Input.GetKey(Right))
        {
            //rb.AddForce(transform.right * Speed, ForceMode.Force);
            //transform.eulerAngles = Vector3.up * 90;
            transform.Rotate(Vector3.down * rotSpeed);
        }
        if(Input.GetKey(Left))
        {
            //rb.AddForce(-transform.right * Speed, ForceMode.Force);
            //transform.eulerAngles = Vector3.up * 270;
            transform.Rotate(Vector3.up * rotSpeed);
        }
        //if(rb.velocity.magnitude>Magnitude)
        //    rb.velocity=new Vector3(
        //                            Mathf.Clamp(rb.velocity.x,0,Magnitude),
        //                            Mathf.Clamp(rb.velocity.y,0,Magnitude),
        //                            Mathf.Clamp(rb.velocity.z,0,Magnitude));
        if (rb.velocity.magnitude > Magnitude)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, Magnitude);
        }
    }
}
