using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverEnd : Interactable
{
    [SerializeField] private Animator roomAnimator;

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
        roomAnimator.SetTrigger("edit");
    }
}