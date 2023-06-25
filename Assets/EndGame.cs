using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Laser3[] ends;
    [SerializeField] private GameObject[] cubes;

    private void Start()
    {
        StartCoroutine(Cubes());
    }

    private void Update()
    {
        if (Check())
        {
            GetComponent<Animator>().SetBool("end", true);
        }
    }

    private bool Check()
    {
        for (int i = 0; i < ends.Length; i++)
        {
            if (!ends[i].Check()) { return false; }
        }
        return true;
    }

    private IEnumerator Cubes()
    {
        yield return new WaitForSeconds(1);
        foreach (var item in cubes)
        {
            item.SetActive(true);
        }
    }
}