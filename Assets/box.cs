using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : Interactable
{
    [SerializeField] LayerMask Box;
    [SerializeField] Transform point;
    
    
    Collider[] hitColliders;
void Update()
{
    if(Input.GetKey(KeyCode.E))
    {
       hitColliders = Physics.OverlapSphere(transform.position, 5,Box);
           if(hitColliders.Length>0)
        {
            hitColliders[0].transform.position=point.position;
        }
    }   
}
}

