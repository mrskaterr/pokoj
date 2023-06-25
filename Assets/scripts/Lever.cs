using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    private AudioSource Audio;
    [SerializeField] private Animator[] doors;

    private Animator animator;

    private void Awake()
    {
        Audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    public override void Interact()
    {
        Audio.Play();
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