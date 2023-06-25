using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destorybullet : MonoBehaviour
{
    public float timer = 3.0f;
    
    
    void Update()
    {
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            Destroy(gameObject);
        }
    }
}
