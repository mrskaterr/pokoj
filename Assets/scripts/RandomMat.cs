using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMat : MonoBehaviour
{
    [SerializeField] private Material[] newMats;

    private void Start()
    {
        if(Random.value >= .9f)
        {
            Material[] newMat = { newMats[Random.Range(0, newMats.Length)] };
            GetComponent<Renderer>().materials = newMat;
        }
    }
}