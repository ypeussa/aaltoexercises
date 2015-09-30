using UnityEngine;
using System.Collections;

// Nested 'if' statements.
// First read the code and figure out what this is going to print, and only then run the game to check.

public class Exercise3 : MonoBehaviour {
	
	void Start () {
		string mushroomColor = "brown";
		string mushroomSize = "medium";

		if (mushroomColor == "red") {
			print("dangerous, don't eat");
		} else if (mushroomColor == "brown") {
			if (mushroomSize == "large") {
				print("check from a mushroom guidebook before eating");
			} else {
				print("OK to eat");
			}
		} else {
			print("unknown");
		}
	}
}
