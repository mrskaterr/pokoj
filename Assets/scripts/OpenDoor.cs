using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Animator>().SetBool("open", true);
    }
}