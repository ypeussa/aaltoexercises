using UnityEngine;
using System.Collections;

// SOLUTION
//
// A person is trying to enter a bar hosting a high stakes poker game.
//
// The bouncer will deny everyone else, but allow in:
// anyone who has at least 50 thousand cash,
// any celebrity who has at least 10 thousand,
// and the bar owner.
//
// Write conditional statements so that the correct reply is printed
// for any values the variables have at the moment.


public class CondExercise5Solution : MonoBehaviour {
	public float moneyInPocket = 40000.0f;
	public bool celebrity = false;
	public bool barOwner = false;
	
	void Start () {
		print("The bouncer says:");
		
		if (barOwner) {
			print ("Welcome, sir!");
		} else if (celebrity == true) { // same as (celebrity)
			if (moneyInPocket >= 10000.0f) {
				print ("Welcome, sir!");
			} else {
				print ("Get lost!");
			}
		} else {
			if (moneyInPocket >= 50000.0f) {
				print ("Welcome, sir!");
			} else {
				print ("Get lost!");
			}
		}
	}	
}
