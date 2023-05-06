using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbullet : MonoBehaviour
{
    private Rigidbody2D rb;
    public float PlyaerBulletSpeed = 10f;
    private GameObject player;
    public float BulletDirection = -1f;
    public bool isFly = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("player");
        BulletDirection = -player.transform.localScale.x;
    }


    void Update()
    {
        rb.velocity = new Vector2( BulletDirection* PlyaerBulletSpeed , 0f);

    }
}