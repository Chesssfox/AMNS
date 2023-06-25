using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshandanim : MonoBehaviour
{
    Animator anim;
    firecontroller controller;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponentInParent<firecontroller>();
    }

    void Update()
    {
        
    }
}
