using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepObjectInterscene : MonoBehaviour {

    public static KeepObjectInterscene instance;
    // Start is called before the first frame update
    void Start() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this);
        } else {
            if (instance != this) {
                Destroy(this);
            }
        }
    }
}
