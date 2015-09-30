using UnityEngine;
using System.Collections;


// The output of this code is a bit wrong. What result do you think the developer intended?
// Modify the 'if' statements so that the output is reasonable.
// For testing you can adjust the value of "speed" directly from the editor.

public class Exercise4 : MonoBehaviour {
	public float speed = 90.0f;

    void Start() {

        if (speed >= 60.0f) {
            print("You only got ticketed.");
        } if (speed >= 80.0f) {
            print("You lost your license for a year but got off lightly.");
        } if (speed >= 100.0f){
            print("You got jail time for reckless endangerment.");
        }
	}
}