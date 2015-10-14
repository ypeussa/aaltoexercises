using UnityEngine;
using System.Collections;

public class BallLost : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D c) {
        var gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.BallLost();
    }
}
