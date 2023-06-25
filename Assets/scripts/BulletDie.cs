using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDie : MonoBehaviour
{
    private float timer;
    public float FlyTime = 1f;
    public GameObject death;
    void Start()
    {
        Die();
    }

    void Die(){
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            Instantiate(death, transform.position,  Quaternion.identity);
            Destroy(gameObject);
        }
    }
    
    void Update()
    {
        
    }
}
