using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArms : MonoBehaviour
{

    [SerializeField] private List<GameObject> arms;
    [SerializeField] private List<string> armsName;
    [SerializeField] private int index = 0;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            index++;
            if (index == arms.Count)
            {
                index = 0;
            }

            Change(index);
        }
    }

    private void Change(int index)
    {

        for (int i = 0; i < arms.Count; i++)
        {
            if (i == index)
            {
                arms[i].SetActive(true);
            }
            else
            {
                arms[i].SetActive(false);
            }

        }

        for (int i = 0; i < armsName.Count; i++)
        {
            if (i == index)
            {
                Debug.Log("Esta utilizando la espada " + arms[i]);
            }
        }

    } 
}
