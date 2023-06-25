using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opengate : Interactable
{
    [SerializeField] Animator animator;

    public override void Interact()
    {
        animator.SetBool("open", true);
    }
}