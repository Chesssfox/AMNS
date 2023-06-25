/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehavior : MonoBehaviour
{
    public Transform raycast;
    public LayerMask raycastMask;
    public float raycastlength;
    public float timer;

    private GameObject target;
    private RaycastHit hit;
    private Animator anim;
    private bool attack;
    private bool inRange;
    private bool colling;
    private float intTimer;
    void Start()
    {
        intTimer = timer;
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTigergerEnter2D(Collider2D trig){
        if(trig.gameObject.tag == Player){
            target = trig.gameObject;
        }
    }
}
*/