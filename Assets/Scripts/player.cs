using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    public float speed;

    void Update()
    {

        Vector3 moviment = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        anim.SetFloat("Horizontal", moviment.x);
        anim.SetFloat("Vertical", moviment.y);
        anim.SetFloat("Speed", moviment.magnitude);

        transform.position = transform.position + moviment * speed * Time.deltaTime;
    }


}
