using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 3.25f;
    public float jumpSpeed;
    
    private Rigidbody2D rb;
    private Vector2 playerInput;
    private bool shouldJump;
    private bool canJump;
 
 
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    // get input values each frame
    private void Update()
    {
        // using "GetAxis" allows for many different control schemes to work here
        // go to Edit -> Project Settings -> Input to see and change them
        playerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
 
        if(canJump && Input.GetKeyDown(KeyCode.Space))
        {
            canJump = false;
            shouldJump = true;
        }
    }
 
    // apply physics movement based on input values
    private void FixedUpdate()
    {
        // move
        rb.AddForce(playerInput * (moveSpeed * Time.fixedDeltaTime));
     
        // jump
        if(shouldJump)
        {
            Vector2 jumpDir = (-Physics2D.gravity).normalized;
            rb.AddForce(jumpDir * jumpSpeed, ForceMode2D.Impulse);
            shouldJump = false;
        }
    }
 
    private void OnCollisionEnter2D(Collision2D col)
    {
        // allow jumping again
        canJump = true;
        transform.tag = "onFloor";
    }
 
    private void OnCollisionExit2D(Collision2D col)
    {
        transform.tag = "Jumping";
    }
}