using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ArraysAndLoops : MonoBehaviour {
	
	// This is a C# array of integer numbers. Array types have brackets after the content type.
	// Public array contents can be set in Unity editor.
	public int[] finishOrder;
	
	// Mentioned at the end of class: we'll use List<T> soon. It's an array as well,
	// but allows increasing and decreasing the size of the array on the fly.
	public List<int> betterArray;
	
	void Start () {
		// This is how you would initialize the contents of the array in code.
		// This also sets the length of the array to 6. The length cannot be changed
		// unless the array is completely rebuilt.
		// finishOrder = new int[] { 3, 6, 1, 2, 4, 5 };
		
		// Using loops to print everything in the array:
		
		// 'while'-loop. You should usually use the other loops, but this is shown first
		// because it has simple syntax and works very much like an 'if' statement.
		// The difference is that at the end of the while-loop, execution jumps back
		// to the beginning and the loop runs again if the condition is still true.
		int i = 0;
		while (i < finishOrder.Length) {
			// Every invididual index of the array, like finishOrder[3], is pretty much
			// just a variable; you can read it like below, or assign a new value into it
			// with =.
			print(finishOrder[i]);
			i = i + 1;
		}
		
		// This 'for'-loop does the exact same thing.
		// Usually results in cleaner, better code than while-loop, because it has clearly
		// defined places where to create an index variable or do other initial setup,
		// and where to advance the loop (usually by incrementing an index variable).
		
		// for ( initial-setup ; condition ; after-each-loop ) { ... }
		
		for ( int j = 0; j < finishOrder.Length; j = j + 1) {
			print(finishOrder[j]);
		}
		
		// Foreach-loop is safer and cleaner when we want to process all items in a
		// container like an array, and we do not need the item's index for any
		// sort of calculations.
		foreach (int finishingPosition in finishOrder) {
			print(finishingPosition);
		}
	}
}
