﻿using UnityEngine;
using System.Collections;

public class SimplePlayer : MonoBehaviour
{

    Animator animator;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        



        if (Input.GetButtonDown("Horizontal"))
        {

            GetComponent<Animator>().SetTrigger("Walk");
        }
  

    }
}

      