using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    public int health = 1;
    void OnCollisionEnter2D(Collision2D c) {
        health--;
        if (health <= 0) {
            Destroy(gameObject, 0.05f);
        }
    }
}
