using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{

    [SerializeField] private GameObject[] door;

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
        foreach (var item in door)
        {
            item.SetActive(!item.activeInHierarchy);
        }
    }
}