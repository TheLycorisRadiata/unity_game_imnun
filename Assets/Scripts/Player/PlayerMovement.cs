using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static Rigidbody rb;
    private static float forwardSpeed, sideStepSpeed, rotationSpeed;
    private static float jumpForce;
    private static bool canJump;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        forwardSpeed = 7f;
        sideStepSpeed = 5f;
        rotationSpeed = forwardSpeed * 10f;

        jumpForce = 5f;
        canJump = false;
    }

    void FixedUpdate()
    {
        float forwardMovement = PlayerInput.movementVector.y * forwardSpeed;
        float sideStepMovement = PlayerInput.sideStepInput * sideStepSpeed;
        float rotationMovement = PlayerInput.movementVector.x * rotationSpeed;

        transform.Translate(new Vector3(sideStepMovement, 0f, forwardMovement) * Time.deltaTime);
        transform.Rotate(new Vector3(0f, rotationMovement, 0f) * Time.deltaTime);

        if (PlayerInput.jumpInput && canJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        } 
    }

    private void OnCollisionEnter()
    {
        canJump = true;
    }
}
