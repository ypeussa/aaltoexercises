using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {

	// [SerializeField]
	public float speed = 1.0f;
	
	// Use this for initialization
	void Start () {
//		transform.position = transform.position + new Vector3(0, 1, 0);
//		transform.position = transform.position + Vector3.up;
//		transform.position += Vector3.up;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 velocity = Vector3.up * speed;
		transform.position += velocity * Time.deltaTime;
	}
}
