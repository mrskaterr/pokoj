using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser2 : MonoBehaviour
{
    [SerializeField] private Transform startPoint;
    private LineRenderer lineRenderer;
    [SerializeField] private int col = 0;

    public int isOn = 0;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate()
    {
        lineRenderer.enabled = Check();
        if (Check())
        {
            SetLaser();
        }
    }

    private bool Check()
    {
        return isOn == col;
    }

    private void SetLaser()
    {
        
        RaycastHit hit;
        if (Physics.Raycast(startPoint.position, startPoint.forward, out hit, Mathf.Infinity))
        {
            lineRenderer.SetPosition(0, startPoint.position);
            lineRenderer.SetPosition(1, hit.point);
        }
        if (hit.transform.GetComponent<Laser3>() != null)
        {
            hit.transform.GetComponent<Laser3>().isOn = col;
            hit.transform.GetComponent<Laser3>().StopS();
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