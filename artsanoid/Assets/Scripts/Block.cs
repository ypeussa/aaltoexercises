using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    public int health = 1;
    public bool breakable = true;
    void OnCollisionEnter2D(Collision2D c) {
        health--;
        if (breakable && health <= 0) { // AND operator for truth values
            Destroy(gameObject, 0.05f);
        }
        // a || b - the OR operator, result is true if either a or b is true
    }
}
