using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossfirehand : MonoBehaviour
{
    public GameObject Bullet;
    public Transform FirePoint;
    public Transform Player;
    public int bulletnum = 3;
    public float bulletangle = 15;
    public float FireInterval = 1f;
    public Vector2 test;
    public int isHand = 1;

    private bool canShoot;
    private float timer = 0f;
    private Animator anim;
    private Vector2 direction;
    private firecontroller controller;
    private enemyhealth heal;

    void Start()
    {
        anim = GetComponent<Animator>();
        controller = GetComponentInParent<firecontroller>();
        heal = GetComponentInParent<enemyhealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.randomHand == isHand || heal.health <= 10){
            Shoot();
        }
    }
    void Shoot(){
        direction = (Player.position - FirePoint.position).normalized;
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            timer = FireInterval;
            anim.SetTrigger("shoot");
            Fire();
        }
    }
    void Fire(){
        int median = bulletnum/2;
        for(int i = 0;i < bulletnum; i++){
            Instantiate(Bullet, FirePoint.position, FirePoint.rotation);
            if(bulletnum%2 == 1){
                Bullet.GetComponent<enemybullet>().SetSpeed(Quaternion.AngleAxis(bulletangle*(i - median),Vector3.forward)*direction); 
                
            }else{
                Bullet.GetComponent<enemybullet>().SetSpeed(Quaternion.AngleAxis(bulletangle*(i - median) + bulletangle/2,Vector3.forward)*direction); 
            }
        }
        
    }

}
