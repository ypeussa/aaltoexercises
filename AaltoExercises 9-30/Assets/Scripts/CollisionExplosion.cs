using UnityEngine;
using System.Collections;

public class CollisionExplosion : MonoBehaviour {
    bool exploded = false;

    void OnCollisionEnter(Collision c) {      
        if (c.gameObject.name != "Ground plane") {
            if (!exploded) {
                GetComponent<ParticleSystem>().Emit(200);
                exploded = true;
            }
        }
    }
}
