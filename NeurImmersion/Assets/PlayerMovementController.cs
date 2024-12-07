using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    // Speed of movement
    public float moveSpeed = 2.0f;

    // Reference to the player's transform
    private Transform playerTransform;

    void Start()
    {
        // Cache the player's transform
        playerTransform = transform;
    }

    void Update()
    {
        // Get input from the left controller joystick
        Vector2 joystickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch);

        // Convert joystick input to movement direction
        Vector3 movementDirection = new Vector3(joystickInput.x, 0, joystickInput.y);

        // Move in the direction of the left controller's orientation
        Vector3 worldMovement = playerTransform.TransformDirection(movementDirection) * moveSpeed * Time.deltaTime;

        // Apply the movement
        playerTransform.position += worldMovement;
    }
}
