using UnityEngine;
using System.Collections;

// This is a simple character controller that lets you move an object
// along the ground in response to arrow key input.
// Only left and forward directions are implemented, you do the rest.

// Task A: add right and back directions to get full 2D movement.

// Task B: put this script on the camera object instead of the original object,
// so you can 'walk around the scene' with the game camera.

// Task C: try rotating the camera object a bit horizontally (around the Y axis)
// and observe what happens to the movement.
//
// This is because the movement is defined in terms of world space directions,
// the rotation of the object doesn't count.
//
// Change the script to use the actual forward, etc. directions of the object itself
// so the movement works nicely regardless of the rotation. See:
// http://docs.unity3d.com/ScriptReference/Transform.html

public class MovementInputExercise : MonoBehaviour {

	public float speed = 3.0f;

	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.position += new Vector3(-1,0,0) * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow)) {
			transform.position += new Vector3(0,0,1) * speed * Time.deltaTime;
		}

		// Task A: Your code here!
	}
}
