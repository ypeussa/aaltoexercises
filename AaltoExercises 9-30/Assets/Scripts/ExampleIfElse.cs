using UnityEngine;
using System.Collections;

public class ExampleIfElse : MonoBehaviour{

    void Start(){
        int apples = 6;

        if (apples > 6){
            print("Enough apples for a party!");
        } else {
            print("Party failing, need more apples.");
        }
    }
}
