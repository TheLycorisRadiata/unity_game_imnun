using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static Transform tr;
    private static Rigidbody rb;
    private static float forwardSpeed, sideStepSpeed, rotationSpeed;
    private static float jumpForce;

    void Awake()
    {
        tr = transform.parent;
        rb = tr.GetComponent<Rigidbody>();
    }

    void Start()
    {
        forwardSpeed = 7f;
        sideStepSpeed = 5f;
        rotationSpeed = forwardSpeed * 10f;
        jumpForce = 5f;
    }

    void FixedUpdate()
    {
        float forwardMovement = PlayerInput.movementVector.y * forwardSpeed;
        float sideStepMovement = PlayerInput.sideStepInput * sideStepSpeed;
        float rotationMovement = PlayerInput.movementVector.x * rotationSpeed;

        tr.Translate(new Vector3(sideStepMovement, 0f, forwardMovement) * Time.deltaTime);
        tr.Rotate(new Vector3(0f, rotationMovement, 0f) * Time.deltaTime);

        if (PlayerInput.jumpInput && JumpCheck.playerCanJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            JumpCheck.playerCanJump = false;
        } 
    }
}
