using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{
    static Animator anim;
    playermovement movemoent;
    private Rigidbody2D rb;
    bool isWalk;
    void Start()
    {
        anim = GetComponent<Animator>();
        movemoent = GetComponent<playermovement>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isWalk",isWalk);
        anim.SetBool("isOnground",movemoent.isOnground);
        anim.SetFloat("JumpCount",movemoent.JumpCount);
        anim.SetFloat("speed",Mathf.Abs(rb.velocity.x));
        if(movemoent.isWalkA == true || movemoent. isWalkD == true){
            isWalk = true;
        }else isWalk = false;
    }
    
}
