using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    [SerializeField] private Animator[] doors;

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
        foreach (var door in doors)
        {
            door.SetBool("open", !door.GetBool("open"));
        }
    }
}