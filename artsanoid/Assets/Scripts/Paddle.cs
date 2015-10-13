using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    public float speed;
    public float maxXposition;

	void FixedUpdate () {
        float input = Input.GetAxis("Horizontal");
        Vector3 newPos = transform.position +
            Vector3.right * speed * input * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, -maxXposition, maxXposition);
        transform.position = newPos;
    }
}
