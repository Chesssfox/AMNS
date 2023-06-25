using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firecontroller : MonoBehaviour
{
    
    public int randomTime;
    public int randomHand;
    public float FireInterval = 1.0f;

    private float timer = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Suiji();
    }
    void Suiji(){
        if(timer !=0){
            timer -= Time.deltaTime;
            if(timer <= 0 ){
                timer = 0;
            }
        }
        if(timer == 0){
            timer = FireInterval;
            randomTime = Random.Range(1,4);
            randomHand = Random.Range(1,4);
        }
    }
    void Fire(){

    }
}
