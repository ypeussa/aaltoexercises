using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
    public Transform waypoint1;
    public Transform waypoint2;

    bool goingTowardFirst;
    NavMeshAgent nav;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        nav.destination = waypoint2.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 currentDestination = goingTowardFirst ? waypoint1.position : waypoint2.position;
	    if (Vector3.Distance(transform.position, currentDestination) < 1.0f) {
            goingTowardFirst = !goingTowardFirst;
            nav.destination = goingTowardFirst ? waypoint1.position : waypoint2.position;
        }
	}
}
