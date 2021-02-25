using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    // Input variables
    public static float horizontalMovement = 0f; // a & d movement
    public static float verticalMovement = 0f; // w & s movement
    public static bool jumping; // true if the player wants to jump
    public static bool sprinting; // true if the player wants to sprint (LShift button)

    // Update is called once per frame
    void Update() {
        GetInput();
    }

    void GetInput() {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        jumping = Input.GetButton("Jump");
        sprinting = Input.GetKey(KeyCode.LeftShift);
    }
}
