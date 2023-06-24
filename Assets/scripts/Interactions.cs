using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private float radius = 2f;
    [SerializeField] private LayerMask interactableMask;
    [SerializeField] private KeyCode interactBtn;

    private void Update()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, interactableMask);
        if (colliders.Length > 0)
        {
            var item = colliders[0];
            for (int i = 0; i < colliders.Length; i++)
            {
                float distanceMin = Vector3.Distance(transform.position, colliders[0].transform.position);
                if (distanceMin >= Vector3.Distance(transform.position, colliders[i].transform.position))
                {
                    distanceMin = Vector3.Distance(transform.position, colliders[i].transform.position);
                    item = colliders[i];
                }
            }
            if (Input.GetKeyDown(interactBtn))
            {
                item.GetComponent<Interactable>().Interact();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}