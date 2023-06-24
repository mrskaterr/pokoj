using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    [SerializeField] private GameObject[] doors;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetState()
    {
        foreach (var item in doors)
        {
            item.SetActive(!item.activeInHierarchy);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        SetState();
        SetAnim(true);
    }

    private void OnTriggerExit(Collider other)
    {
        SetState();
        SetAnim(false);
    }

    private void SetAnim(bool _p)
    {
        animator.SetBool("Used", _p);
    }
}