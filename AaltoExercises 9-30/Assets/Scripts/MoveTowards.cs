using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {
	public GameObject target;
	public float speed = 2.0f;

	void Update () {
		// Figure out a direction from two positions, then move in that direction at specific speed.

		// Vector3 targetDirection = (target.transform.position - transform.position).magnitude;
		// transform.position += targetDirection * speed * Time.deltaTime;

		// You should understand everything that's going on above. It works, but you get oscillation
		// at the end, because the objects don't end exactly on top of each other and never stop moving.
		// To take care of the oscillation we'd need to clamp maximum movement amount to the distance of
		// the other object, or simply stop moving our object when it's close enough.

		// A clean solution using Unity built-in Vector3.MoveTowards helper function.
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
	}
}
