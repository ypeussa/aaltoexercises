using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListExample : MonoBehaviour {
    public int[] someArray;
    public List<int> betterArray;

	// Use this for initialization
	void Start () {
        someArray = new int[] { 3, 2, 1 };
        someArray = new int[] { 2, 2, 1, 7, 8 };
        betterArray.Add(3);
        betterArray.Add(2);
        betterArray.Add(4);
        betterArray.Add(5);
        betterArray[3] = 99999;
        betterArray.Insert(0, 77777);
        if (betterArray.Remove(1010101))
        {
            print("succeeded at removing this value");
        }
        betterArray.RemoveAt(3);

        print(betterArray[0]);
        print(betterArray[1]);
        print(betterArray[2]);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
