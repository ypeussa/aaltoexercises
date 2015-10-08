using UnityEngine;
using System.Collections;

public class TriggerExplosion : MonoBehaviour {
    bool exploded = false;

    void OnTriggerEnter(Collider c) {
        if (c.gameObject.name != "Ground plane") {
            if (!exploded) {
                GetComponent<ParticleSystem>().Emit(200);
                exploded = true;
            }
        }
    }
}
