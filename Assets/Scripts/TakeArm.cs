using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeArm : MonoBehaviour
{

    [SerializeField] GameObject[] swords;
    public int cont;

    public void ActivateSwords(int index)
    {
        for (int i = 0; i < swords.Length; i++)
        {
            swords[i].SetActive(false);
        }

        swords[index].SetActive(true);
        cont++;
    }

}
