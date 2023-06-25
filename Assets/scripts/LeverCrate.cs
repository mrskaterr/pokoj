using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverCrate : Interactable
{
    [SerializeField] private Animator door;
    [SerializeField] private GameObject crate;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float power;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void Interact()
    {
        if (animator)
        {
            animator.SetBool("Used", !animator.GetBool("Used"));
        }
        door.SetBool("open", true);
        var clone = Instantiate(crate, spawnPoint);
        clone.GetComponent<Rigidbody>()?.AddForce(spawnPoint.transform.forward * power);
    }
}