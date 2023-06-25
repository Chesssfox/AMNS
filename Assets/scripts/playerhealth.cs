using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public int health = 100;
    public GameObject death;
    public float cd;
    private Animator anim;
    private float timer = 0;

    void Awake(){
        anim = GetComponent<Animator>();
    }
    public void TakeDamage(int damage){
        health -= damage;
        if(damage > 0){        
            if(health <= 0){
            Die();
        }   else{
            HeartAnim();
        }
        }
    } 
    void HeartAnim(){
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            timer = cd;
            anim.SetTrigger("Hurt");
        }
    }
    void Die(){
        Instantiate(death, transform.position,  Quaternion.identity);
        Destroy(gameObject);
    }   
}
