using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : Interactable
{
    [SerializeField] private GameObject currentLvl;

    [SerializeField] private Animator[] animators;

    public override void Interact()
    {
        currentLvl.GetComponent<Animator>()?.SetTrigger("edit");
        foreach (var item in animators)
        {
            item.SetTrigger("despawn");
        }
    }
}