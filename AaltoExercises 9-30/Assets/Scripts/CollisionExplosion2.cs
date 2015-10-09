using UnityEngine;
using System.Collections;

public class CollisionExplosion2 : MonoBehaviour {
    bool exploded = false;

    void onCollisionEnter(Collision c) {
        if (c.gameObject.name != "Ground plane") {
            if (!exploded) {
                GetComponent<ParticleSystem>().Emit(200);
                exploded = true;
            }
        }
    }
}
