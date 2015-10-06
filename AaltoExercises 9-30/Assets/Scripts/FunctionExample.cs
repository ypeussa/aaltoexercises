using UnityEngine;
using System.Collections;

public class FunctionExample : MonoBehaviour {

    void PrintManyTimes(string str, int howMany)
    {
        string s = "";
        for (int i = 0; i < howMany; i++)
        {
            s += str + " ";
        }
        print(s);
    }

    bool isOdd(int i)
    {
        bool result = i % 2 == 1;
        return result; // ends function, returns value
    }

    // Use this for initialization
    void Start () {
        string str = "la";

        PrintManyTimes("lol", 5);
        // ...
        PrintManyTimes("zzz", 8);
        print("Is 7 odd? " + isOdd(7));
    }

    // Update is called once per frame
    void Update () {
	
	}
}
