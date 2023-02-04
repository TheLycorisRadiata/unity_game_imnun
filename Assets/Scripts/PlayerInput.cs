using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public static Vector2 movementVector;
    public static float sideStepInput;

    public static void OnMove(InputAction.CallbackContext ctx)
    {
        movementVector = ctx.ReadValue<Vector2>();
    }

    public static void OnSideStep(InputAction.CallbackContext ctx)
    {
        sideStepInput = ctx.ReadValue<float>();
    }
}
