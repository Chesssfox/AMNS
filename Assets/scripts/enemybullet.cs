using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll; 
    public float BulletSpeed = 10f;
    public Vector2 test;
    public Vector2 BulletDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        rb.velocity = BulletDirection * BulletSpeed;
    }

    public void SetSpeed(Vector2 direction){
        BulletDirection = direction;
    }
    private void OnTriggerEnter2D(Collider2D hitinfo) {
        playerhealth player =  hitinfo.GetComponent<playerhealth>();
        if(player !=null){
            player.TakeDamage(1);
        }
    }
}