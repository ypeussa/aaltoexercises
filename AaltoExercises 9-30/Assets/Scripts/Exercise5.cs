using UnityEngine;
using System.Collections;

// A person is trying to enter a bar hosting a high stakes poker game.
//
// The bouncer will deny everyone else, but allow in:
// anyone who has at least 50 thousand cash,
// any celebrity who has at least 10 thousand,
// and the bar owner.
//
// Write conditional statements so that the correct reply is printed
// for any values the variables have at the moment.

public class Exercise5 : MonoBehaviour {

	public float moneyInPocket = 40000.0f;
	public bool celebrity = false;
	public bool barOwner = false;

	void Start () {
		print("The bouncer says:");

		// print ("Welcome, sir!");

		// print ("Get lost!");
	
	}	
}
