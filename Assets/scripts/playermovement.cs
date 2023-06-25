using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    public GameObject Shadow;
    [Header("move")]
    public float walkspeed = 8f;
    public float runspeed = 10f;
    public float xVelocity;
    [Header("status")]
    public bool isCrouch;	
    public bool isOnground;
    public bool isWalkA;
    public bool isWalkD;
    public int JumpCount;
    [Header("jump")]
    public float jumpforce1 = 6.3f;
    public float jumpforce2 = 12.6f;
    [Header("environment")]
    public LayerMask groundLayer;
    public float footOffset = 0.37f;
    public float headDistance = 0.615f;
    public float rayLength = 0.2f;
    public float timeVal = 0.2f;

    
    //keys
    bool jumpPressed;
    bool crouchHeld;
    
    bool walkFlag;
    float pressATime;
    float pressDTime;
    float relaseAtime;
    float relaseDtime;
    

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }
    
    void Update(){
    	if(Input.GetButtonDown("Jump")){
            jumpPressed = true;
        }
        GroundMovement();
        PhysicsCheck();
    }

    void FixedUpdate () {
        

    }

    void PhysicsCheck(){
        RaycastHit2D leftfootCheck = Raycast(new Vector2(-footOffset,-headDistance),Vector2.down, rayLength, groundLayer);
        RaycastHit2D rightfootCheck = Raycast(new Vector2(footOffset,-headDistance),Vector2.down, rayLength, groundLayer);
    	if(leftfootCheck || rightfootCheck){
    	  isOnground = true;
          Shadow.SetActive(true);
          JumpCount = 0;
        }else {
            isOnground = false;
            Shadow.SetActive(false);
        }     
    }
    void GroundMovement(){    	
       if(Input.GetKeyUp(KeyCode.A)){
        relaseAtime = Time.time;
        rb.velocity = new Vector2(0,0);
        isWalkA = false;
       }
       if(Input.GetKeyDown(KeyCode.A)){
        isWalkA = true;
       }
       if(Input.GetKeyUp(KeyCode.D)){
        relaseDtime = Time.time;
        rb.velocity = new Vector2(0,0);
        isWalkD = false;
        }
        if(Input.GetKeyDown(KeyCode.D)){
        isWalkD = true;
       }
       if(Input.GetKey(KeyCode.A)){
        pressATime = Time.time;
        if(pressATime - relaseAtime <= timeVal){
            rb.velocity = new Vector2 (-runspeed , rb.velocity.y);
            relaseAtime = Time.time;
        }else rb.velocity = new Vector2 (-walkspeed , rb.velocity.y);
       }
       if(Input.GetKey(KeyCode.D)){
        pressDTime = Time.time;
        if(pressDTime - relaseDtime <= timeVal){
            rb.velocity = new Vector2 (runspeed , rb.velocity.y);
            relaseDtime = Time.time;
        }else rb.velocity = new Vector2 (walkspeed , rb.velocity.y);
        if(!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)){
            isWalkA = false;
            isWalkD = false;
        }
       }
       /* xVelocity = Input.GetAxis("Horizontal");
    	rb.velocity = new Vector2(xVelocity * walkspeed , rb.velocity.y);*/
    	FilpDirction();
        Jump();
    }
    void Attack(){

    }
    void Jump(){
        if (jumpPressed && isOnground && JumpCount == 0){
            isOnground = false;
            //rb.AddForce(new Vector2(0f,jumpforce1),ForceMode2D.Impulse);
            rb.velocity = new Vector2(0f,jumpforce1);
        }else if(!isOnground && JumpCount == 0){
            JumpCount++;
        }else if(jumpPressed && JumpCount == 1){
            JumpCount++;
            //rb.AddForce(new Vector2(0f,jumpforce2),ForceMode2D.Impulse); 
            rb.velocity = new Vector2(0f,jumpforce2);        
        }
        jumpPressed = false;  
    }
    void FilpDirction(){
        if (isWalkA == true){
            transform.localScale = new Vector2(1,1);
        }	
    	if (isWalkD == true){

    		transform.localScale = new Vector2(-1,1);
        }

    }

    RaycastHit2D Raycast(Vector2 offset, Vector2 rayDirection, float length, LayerMask Layer){
        Vector2 pos = transform.position;
        RaycastHit2D Hit = Physics2D.Raycast(pos+offset,rayDirection,length,Layer);
        Color color = Hit ? Color.red : Color.green;
        //Debug.DrawRay(pos+offset,rayDirection * length,color);
        return Hit;
    }

}