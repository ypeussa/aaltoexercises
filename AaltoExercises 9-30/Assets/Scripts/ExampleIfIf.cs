using UnityEngine;
using System.Collections;

public class ExampleIfIf : MonoBehaviour {

    // Use this for initialization
    void Start() {
        float speed = 90.0f;

        if (speed >= 60.0f) {
            print("You got fined.");
        }

        if (speed >= 80.0f) {
            print("You lost your license.");
        }

        if (speed >= 100.0f){
            print("You got jailtime.");
        }
	}
}
