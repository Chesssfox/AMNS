using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshandhit : MonoBehaviour
{
    public float FireInterval = 10f;

    private float timer = 0f;
    private Animator anim;
    private GameObject player;
    Rigidbody2D playerrb;
    void Start()
    {
        anim = GetComponent<Animator>();
        GameObject player = GameObject.Find("player");
        Rigidbody2D playerrb = player.GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        Hit();
    }
    void Hit(){
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            timer = FireInterval;
            anim.SetTrigger("hit");
            playerrb.velocity = new Vector2(playerrb.velocity.x , 10f);
        }
    }
}
