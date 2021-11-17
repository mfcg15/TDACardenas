using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsController : MonoBehaviour
{
    private TakeArm sword;
    [SerializeField] int numberSword;
    [SerializeField] string nameSword;

    void Start()
    {
        sword = GameObject.FindGameObjectWithTag("Player").GetComponent<TakeArm>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sword.ActivateSwords(numberSword);
            Debug.Log("Ahora posees la espada " + nameSword);
            Destroy(gameObject);
        }
    }
}
