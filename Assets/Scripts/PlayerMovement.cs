using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private static float forwardSpeed, sideStepSpeed, rotationSpeed;

    void Start()
    {
        forwardSpeed = 7f;
        sideStepSpeed = 5f;
        rotationSpeed = forwardSpeed * 10f;
    }

    void FixedUpdate()
    {
        float forwardMovement = PlayerInput.movementVector.y * forwardSpeed;
        float sideStepMovement = PlayerInput.sideStepInput * sideStepSpeed;
        float rotationMovement = PlayerInput.movementVector.x * rotationSpeed;

        transform.Translate(new Vector3(sideStepMovement, 0f, forwardMovement) * Time.deltaTime);
        transform.Rotate(new Vector3(0f, rotationMovement, 0f) * Time.deltaTime);
    }
}
