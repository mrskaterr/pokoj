using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButton : Interactable
{
    AudioSource audio;
    [SerializeField] private GameObject currentLvl;
    [SerializeField] LayerMask Player;
    [SerializeField] private Animator[] animators;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public override void Interact()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1,Player);
            if(hitColliders.Length>1)
            {
                audio.Play();
                currentLvl.GetComponent<Animator>()?.SetTrigger("edit");
                foreach (var item in animators)
                {
                    item.SetTrigger("despawn");
                }
            }


    }
}