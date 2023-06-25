using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser3 : MonoBehaviour
{
    [SerializeField] private int col = 0;
    [SerializeField] private Material[] off;
    [SerializeField] private Material[] on;
    [SerializeField] private Renderer Renderer;

    public int isOn = 0;

    public bool Check()
    {
        return isOn == col;
    }

    private void Update()
    {
        if (Check())
        {
            Renderer.materials = on;
        }
        else
        {
            Renderer.materials = off;
        }
    }

    public void SetC(int _p)
    {
        isOn = _p;
    }

    public void StopS()
    {
        StopAllCoroutines();
        StartCoroutine(Stop());
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(.2f);
        isOn = 0;
    }
}