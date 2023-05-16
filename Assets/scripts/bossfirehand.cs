/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossfirehand : MonoBehaviour
{
    public GameObject Bullet;
    private float timer = 0f;
    private Animator anim;
    public int bulletnum = 3;
    public float bulletangle = 15;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        void Fire(){
            if(bulletnum %2 ==1){
                Bullet.GetComponent<>
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
}
*/