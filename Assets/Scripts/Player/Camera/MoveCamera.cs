﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public float mouseSensitivity = 500f;
    public Transform playerBody;

    float xRotation = 0f;

    const string MouseX = "Mouse X";
    const string MouseY = "Mouse Y";

    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        DoRotation();
    }

    void DoRotation() {
        float mouseX = GetMouseAxisValue(MouseX);
        float mouseY = GetMouseAxisValue(MouseY);
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    float GetMouseAxisValue(string axisName) {
        if (!axisName.Equals(MouseX) && !axisName.Equals(MouseY)) return 0;
        return Input.GetAxis(axisName) * mouseSensitivity * Time.deltaTime;
    }
}