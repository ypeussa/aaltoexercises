using UnityEngine;
using System.Collections;

public class TriggerRelay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void OnTriggerEnter(Collider c)
    {
        // GameObject gm = GameObject.Find("GameManager");

        // This line of code below is exactly the same; 'gm' is still type 'GameObject'.
        // The C# compiler knows it because we're assigning that type into the variable immediately,
        // and because of that we can shorten our code by writing 'var'.
        // It's safe to use 'var' because if the compiler could not figure out we mean 'GameObject',
        // you would immediately get an error, there's no risk of bugs from it.
        // In your own code, you can either spell out the type or write 'var', whichever you find
        // easier to read.
        var gm = GameObject.Find("GameManager");

        SnakeManager sm = gm.GetComponent<SnakeManager>();
        sm.TriggerGameOver();
    }
}
