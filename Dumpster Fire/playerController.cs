using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject character;
    public float moveSpeed = 3.25f;
    public float jumpSpeed;
    public Rigidbody2D rb;
 
    private Vector2 playerInput;
    private bool shouldJump;
    private bool canJump;
 
 
    private void Start()
    {
        rb = character.GetComponent<Rigidbody2D>();
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
        if(playerInput != Vector2.zero) {
            rb.AddForce(playerInput * (moveSpeed * Time.fixedDeltaTime), ForceMode2D.Impulse);
        }
     
        // jump
        if(shouldJump) {
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            shouldJump = false;
        }
    }
 
    private void OnCollisionEnter2D(Collision2D col)
    {
        // allow jumping again
        canJump = true;
        character.transform.tag = "onFloor";
    }
 
    private void OnCollisionExit2D(Collision2D col)
    {
        character.transform.tag = "Jumping";
    }
}