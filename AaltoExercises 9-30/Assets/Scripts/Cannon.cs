using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {

	public GameObject projectile;
	public float projectileLaunchSpeed = 10.0f;

	ParticleSystem muzzleBlast;

	void Start () {
		muzzleBlast = transform.FindChild("MuzzleBlast").GetComponent<ParticleSystem>();
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Fire();
		}

	}

	public void Fire() {
		muzzleBlast.Emit(100);
		var go = Instantiate<GameObject>(projectile);
		go.transform.position = muzzleBlast.transform.position;
		go.transform.rotation = Quaternion.LookRotation(transform.forward);
		go.GetComponent<Rigidbody>().velocity = transform.forward * projectileLaunchSpeed;
		Destroy (go, 3.0f);
	}
}
