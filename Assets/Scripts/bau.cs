using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bau : MonoBehaviour
{
  

    void Start()
    {       
        GetComponent<Animator>().enabled =false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
