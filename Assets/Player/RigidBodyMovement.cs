using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    private float speed;
    private int canJump = 0;
    private int frameJumpLimit = 5;

    [Header("Refrences")]
    public Rigidbody2D body;
    public Transform groundCheck;
    public LayerMask ground;
    [Header("Public changeables")]
    public bool isGrounded;
    public float move = 1f; //-1 to 1
    public bool jump; //0 or 1
    [Header("Values To Change")]
    public float baseSpeed = 10f;
    public float airResistance = 5f;
    public float jumpHight;
    public float fallMultiplier = 2.5f;
    private void Update() 
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.3f, ground);

        if(isGrounded)
        {
            speed = baseSpeed;
            body.velocity = Vector2.down * 0;
            if(jump && canJump >= frameJumpLimit)
            {
                body.AddForce(Vector2.up * jumpHight);
                canJump = 0;
            }
            else
            {
                canJump++;
            }
        }
        else
        {
            speed = baseSpeed / airResistance;
        }
    }
    private void FixedUpdate() 
    {
        //Jump?
        if(body.velocity.y < 0)
        {
            body.velocity += Vector2.up * Physics2D.gravity.y * ((fallMultiplier - 1) * Time.deltaTime);
        }

        //Move
        body.AddForce(Vector2.right * speed * move, ForceMode2D.Impulse);
    }
    public void activateJump()
    {
        jump = true;
        Debug.Log("FUCK");
    }
    public void deactivateJump()
    {
        jump = false;
        Debug.Log("FUCK ENDS");
    }
}
