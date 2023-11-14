using UnityEngine;
using UnityEngine.UI;

public class GravityController : MonoBehaviour
{
    public Slider gravitySlider;
    public GameObject targetObject;
    private Rigidbody2D targetRigidbody;
    private Vector2 ogGravity;

    private void Start()
    {
        ogGravity = Vector2.down * 9.81f;
        // Make sure the target object has a Rigidbody component
        targetRigidbody = targetObject.GetComponent<Rigidbody2D>();
        if (targetRigidbody == null)
        {
            Debug.LogError("Target object must have a Rigidbody component.");
        }

        // Set the initial gravity
        SetGravity(ogGravity);
    }

    private void Update()
    {
        // Update gravity based on the slider value
        UpdateGravity();
    }

    private void UpdateGravity()
    {
        float sliderValue = gravitySlider.value;

        // Check slider value and set gravity accordingly
        if (Mathf.RoundToInt(sliderValue) == 1)
        {
            SetGravity(ogGravity); // Normal gravity
        }
        else if (Mathf.RoundToInt(sliderValue) == 2)
        {
            SetGravity(Vector2.zero); // No gravity
        }
        else if (Mathf.RoundToInt(sliderValue) == 3)
        {
            SetGravity(-ogGravity); // Reverse gravity
        }
    }

    private void SetGravity(Vector2 gravity)
    {
        //targetRigidbody.velocity = Vector2.zero; // Reset velocity when changing gravity
        Physics2D.gravity = gravity;
    }
}