using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;

    // Update is called once per frame
    void Update() {
        Vector3 pos = player.position;
        pos.y++;
        transform.position = pos;
    }
}
