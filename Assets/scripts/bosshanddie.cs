using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosshanddie : MonoBehaviour
{
    enemyhealth heal;
    void Start()
    {
        heal = GetComponentInParent<enemyhealth>();
    }

    void HandDie(){
        if(heal.health <= 0){
            Destroy(gameObject);
        }
    }

}
