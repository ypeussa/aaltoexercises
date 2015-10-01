using UnityEngine;
using System.Collections;

//---

public class LoopExercise5 : MonoBehaviour {

	public int firstNumber;
	public int secondNumber;

	void Start () {
	
		//If firstNumber is less than secondNumber
		//Count up
		if (firstNumber < secondNumber) {
			for (int i = firstNumber; i <= secondNumber; i++) {
				print (i);
			}
			//If fistNumber is more than secondNumber
			//Count down
		} else {
			for (int i = firstNumber; i >= secondNumber; i--) {
				print (i);
			}
		}
	}
}
