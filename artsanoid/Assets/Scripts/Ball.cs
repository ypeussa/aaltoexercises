using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float initialSpeed;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (new Vector2(1, 1)).normalized * initialSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
