using UnityEngine;
using System.Collections;

// 'If' statement with 'else if' and 'else' clauses. 
// First read the code and figure out what this is going to print, and only then run the game to check.


public class Exercise2 : MonoBehaviour {
	
	void Start () {

		float coffeeTemperature = 80.0f;

		if (coffeeTemperature > 85.0f) {
			print("dangerously hot");
		} else if (coffeeTemperature > 70.0f) {
			print("hot");
		} else if (coffeeTemperature > 55.0f) {
			print("cooling down");
		} else {
			print("time to brew a new pot");
		}
	
	}
}
