using UnityEngine;
using System.Collections;

public class Chase : MonoBehaviour {
    public Transform target;

    public bool seesTarget;
    public float sightRange;
    public float sightAngleRange;

    public bool hasSightRange;
    public bool hasSightAngleRange;

	void Update () {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        int layerMask = ~(1 << 9); // do not hit characters (layer 9) but hit everything else
        bool hit = Physics.Raycast(transform.position,
            (target.position + Vector3.up - transform.position),
            distanceToTarget,
            layerMask);
        seesTarget = !hit;

        if (hasSightRange && distanceToTarget > sightRange) {
            seesTarget = false;
        }
        if (hasSightAngleRange &&
            Vector3.Angle(transform.forward, target.position - transform.position) > sightAngleRange) {
            seesTarget = false;
        }

        if (seesTarget) {
            GetComponent<NavMeshAgent>().destination = target.position;
        }

    }

    void OnDrawGizmos() {
        if (hasSightRange) {
            Gizmos.DrawWireSphere(transform.position, sightRange);

        }
    }
}
