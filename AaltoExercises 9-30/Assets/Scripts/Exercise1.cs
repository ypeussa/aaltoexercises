using UnityEngine;
using System.Collections;

// Remember to set the game object with this script as active by checking the box
// in the Unity editor Inspector window next to the object's name.
// Otherwise this code in the object's script component won't run. 
// 
// First read the code and figure out what this is going to print, and only then run the game to check.

public class Exercise1 : MonoBehaviour {

    void Start() {

        int apples = 83;
		int horses = 4;
		float applesPerHorse = apples / horses;

        if (applesPerHorse > 21.0f){
			print("The horses have had their fill of apples and have no motivation to work.");
        } else {
			print("Mutiny at the stables due to insufficient apples.");
        }
		print ("Things didn't go too well.");
    }
}
