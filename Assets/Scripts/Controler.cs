using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Controler : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer sprite;
    BoxCollider2D bc2d;
    public float jumpForse;
    bool isGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatISgroun;
    private int extraJump;
    public int extraJumpValue;
    public Vector2 moveVector;
    [SerializeField] int speed;
    float horizontalSpeed;
    [SerializeField] float Speed_;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        bc2d = GetComponent<BoxCollider2D>();
        extraJump = extraJumpValue;
    }

    private void Update()
    {
        if(isGround == true)
        {
            extraJump = extraJumpValue;
        }
        if(Input.GetKeyDown(KeyCode.Space) && extraJump > 0)
        {
            animator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForse;
        }else if (Input.GetKeyDown(KeyCode.Space) && extraJump == 0 && isGround==true)
        {
            animator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForse;
        }
    }
    private void FixedUpdate()
    { 
        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatISgroun);
         
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            animator.SetBool("isRunning", true);
            sprite.flipX = false;
        }else if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            animator.SetBool("isRunning", true); 
            sprite.flipX = true;
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            animator.SetBool("isRunning", false);
        }
        transform.Translate(horizontalSpeed, 0, 0);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ladder"))
        {
            rb.gravityScale = 0;
            if (Input.GetKey(KeyCode.W))
            {
                rb.velocity = new Vector2(0, speed);
                animator.SetBool("isClimbing", true);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                rb.velocity = new Vector2(0, -speed);
                animator.SetBool("isClimbing", true);
            }
            else
            {
                rb.velocity = new Vector2(0, 0);
                animator.SetBool("isClimbing", false);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        rb.gravityScale = 1;
    }
    public void JumpButton()
    {
        if (isGround == true)
        {
            extraJump = extraJumpValue;
        }
        if (extraJump > 0)
        {
            animator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForse;
        }
        else if (extraJump == 0 && isGround == true)
        {
            animator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForse;
        }
    }
    public void LeftMoveButton()
    {
        FixedUpdate();
        animator.SetBool("isRunning", true);
        horizontalSpeed = -Speed_;
        sprite.flipX = true;
    }
    public void RightMoveButton()
    {
        FixedUpdate();
        animator.SetBool("isRunning", true);
        horizontalSpeed = Speed_;
        sprite.flipX = false;
    }
    public void stop()
    {
        horizontalSpeed = 0;
    }
}
