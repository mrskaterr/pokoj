using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    private LineRenderer lineRenderer;

    AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        lineRenderer = GetComponent<LineRenderer>();
    }
    private void FixedUpdate()
    {
        SetLaser();
    }

    private void SetLaser()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(startPoint.position, transform.forward, out hit, Mathf.Infinity))
        {
            lineRenderer.SetPosition(0, startPoint.position);
            lineRenderer.SetPosition(1, hit.point);

            if(hit.collider.GetComponent<Rigidbody>() && !audio.isPlaying )
            {
                audio.Play();
            }
                

                
        }
    }
}