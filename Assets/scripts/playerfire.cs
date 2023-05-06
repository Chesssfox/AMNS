using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfire : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public float FireInterval = 0.3f;
    private float timer = 0f;
    private Animator anim;

    void Awake(){
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J)){
            Shoot();
        }
    }
    void Shoot(){
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            timer = FireInterval;
            anim.SetTrigger("shoot");
            Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        }
    }
}
