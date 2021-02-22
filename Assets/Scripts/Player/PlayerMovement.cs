using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // components
    public Rigidbody rigidBody;

    // misc variables
    bool grounded;
    public LayerMask groundLayer; // layer which represents the ground

    // Input variables
    float horizontalMovement = 0f; // a & d movement
    float verticalMovement = 0f; // w & s movement
    bool jumping; // true if the player wants to jump
    bool sprinting; // true if the player wants to sprint (LShift button)

    // constants
    const float MaxSpeed = 20f;
    const float MaxSprintingSpeed = 30f;

    void Start() {

    }

    // Update is called once per frame
    void Update() {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        jumping = Input.GetButton("Jump");
        sprinting = Input.GetKey(KeyCode.LeftShift);
    }

    void FixedUpdate() {
        
    }

    void Movement() {
        rigidBody.AddForce(Vector3.down * Time.deltaTime); // keep player on the ground.

        
    }

    void GroundedCheck() {
        
    }

    private void OnCollisionStay(Collision collision) {
        //if (collision.)
    }
}
