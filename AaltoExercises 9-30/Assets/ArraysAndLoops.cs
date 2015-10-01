using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArraysAndLoops : MonoBehaviour {

	public int[] finishOrder;
	public List<int> betterArray;

	// Use this for initialization
	void Start () {
		// finishOrder = new int[] { 3, 6, 1, 2, 4, 5 };
		// print(finishOrder[0]);

		int i = 0;
		while (i < finishOrder.Length) {
			print(finishOrder[i]);
			i = i + 1;
		}

		// for ( initial setup ; condition ; end-of-loop action )

		for ( int j = 0; j < finishOrder.Length; j = j + 1) {
			print(finishOrder[j]);
		}

		foreach (int finishingPosition in finishOrder) {
			print(finishingPosition);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
