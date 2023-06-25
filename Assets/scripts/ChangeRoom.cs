using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRoom : MonoBehaviour
{
    [SerializeField] private GameObject currentLvl;
    [SerializeField] private GameObject nextLvl;

    public void NextLevel()
    {
        currentLvl.SetActive(false);
        nextLvl.SetActive(true);
    }
}
