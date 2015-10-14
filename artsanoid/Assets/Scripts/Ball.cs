using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    public float initialSpeed;
    public float minimumAngle = 20.0f;

    Rigidbody2D rb;

    Vector3 initialPosition;
    Vector2 oldVelocity;

    public void ResetBall() {
        rb.position = initialPosition;
        // rb.velocity = (new Vector2(1, 1)).normalized * initialSpeed;
        rb.velocity = (new Vector2(-1.0f, 0.02f)).normalized * initialSpeed;
    }

    // Use this for initialization
    void Start () {
        initialPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
        ResetBall();
	}
	
    void OnCollisionEnter2D(Collision2D c) {
        // prevent ball from slowing down or speeding up in collisions
        var newVelocity = rb.velocity.normalized * initialSpeed;

        Vector2 rotatedVelocity = newVelocity;
        // fix angle if the ball would end up going too close to horizontal
        float angle = Vector2.Angle(rb.velocity, Vector2.right);
        if (angle < minimumAngle) {
            print("Going directly right!");
            if (oldVelocity.y > 0) {
                print("Was going up");
                Quaternion rotateSlightlyUp = Quaternion.AngleAxis(minimumAngle, Vector3.forward);
                newVelocity = rotateSlightlyUp * Vector3.right * initialSpeed;
            }
            // EXERCISE: fix the case where we bounce almost horizontally downward
        }
        if (180 - angle < minimumAngle) {
            print("Going directly left!");
            if (oldVelocity.y > 0) {
                // EXERCISE: fix this case
            } else {
                print("Was going down!");
                Quaternion rotateSlightlyUp = Quaternion.AngleAxis(minimumAngle, Vector3.forward);
                rotatedVelocity = rotateSlightlyUp * (-Vector3.right) * initialSpeed;
            }
        }
        rb.velocity = newVelocity;
    }

    void FixedUpdate() {
        oldVelocity = rb.velocity;
    }
}
