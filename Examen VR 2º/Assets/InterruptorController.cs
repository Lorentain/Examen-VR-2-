using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptorController : MonoBehaviour
{
    [SerializeField] private GameObject luz;

    public void Pulsar() 
    {
        if (luz.activeInHierarchy)
        {
            luz.SetActive(false);
            gameObject.GetComponent<Animator>().SetBool("PulsarBool",false);
        }
        else
        {
            luz.SetActive(true);
            gameObject.GetComponent<Animator>().SetBool("PulsarBool",true);
        }
    }
}
