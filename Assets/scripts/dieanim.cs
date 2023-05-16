using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieanim : MonoBehaviour
{
    private Animator anim;
    private AnimatorStateInfo info;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        info = anim.GetCurrentAnimatorStateInfo(0);
        if(info.normalizedTime >= 1){
            Destroy(gameObject);
        }
    }
}
