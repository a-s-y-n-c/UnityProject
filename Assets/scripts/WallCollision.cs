using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private Animator animator;

    // Set this layer in the Inspector or via code
    public LayerMask collisionLayer;

    private void Start()
    {
        // Assuming your animator is attached to the same GameObject
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object is on the specified layer
        if (collision.gameObject.layer == collisionLayer)
        {
            // Trigger the animation
            animator.SetBool("WallTouch", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Check if the colliding object is on the specified layer
        if (collision.gameObject.layer == collisionLayer)
        {
            // Stop the animation
            animator.SetBool("WallTouch", false);
        }
    }
}