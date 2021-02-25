using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationHelper : MonoBehaviour {

    public static bool IsFloor(Vector3 vector, float maxSlopeAngle) {
        float angle = Vector3.Angle(Vector3.up, vector);
        return angle < maxSlopeAngle;
    }
}
