using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    public static bool playerCanJump;

    void Start()
    {
        playerCanJump = false;
    }

    private void OnCollisionEnter()
    {
        playerCanJump = true;
    }
}
