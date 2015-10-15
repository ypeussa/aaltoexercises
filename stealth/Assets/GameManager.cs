using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    MouseSelection currentSelection;
    
    public void NewSelection(MouseSelection m) {
        if (currentSelection != null) {
            // talk to last selected object - it stops being selected
            currentSelection.Unselect();
        }
        currentSelection = m;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (currentSelection) {
            if (Input.GetMouseButtonDown(1)) {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // bool didWeHit = Physics.Raycast(ray); // simplest possible raycast
                //if (didWeHit)
                //    print("Hit!");
                //else
                //    print("Did not hit!");
                int layerMask = 1 << 8; // only ground layer (index 8) can be hit

                // some advanced bit manipulation for complex layer masks:
                // negation: ~(1 << 8): hit anything _except_ layer 8
                // selecting multiple layers with the bit-OR operator:
                // (1 << 10) | (1 << 8): hit both layers 8 and 10, nothing else

                RaycastHit hit;
                bool didWeHit = Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask);
                if (didWeHit) {
                    // currentSelection.transform.position = hit.point;
                    currentSelection.GetComponent<NavMeshAgent>().destination = hit.point;
                }
            }
        }
	}
}
