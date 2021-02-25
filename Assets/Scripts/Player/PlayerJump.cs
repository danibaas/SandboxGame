using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour {

    private static bool canJump = true;

    // constants
    const float JumpForce = 100f;

    public static void HandleJumping(Rigidbody rb) {
        if (CanJump()) {
            Jump(rb);
        }
    }

    private static bool CanJump() {
        return (canJump && PlayerInput.jumping);
    }

    private static void Jump(Rigidbody rb) {
        rb.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
    }
}
