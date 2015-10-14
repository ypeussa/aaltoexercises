using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public int nx, ny;
    public float xFromCenter;
    public float yStart;
    public float yEnd;
    public float durableBlockProb = 0.2f;
    public float unbreakableBlockProb = 0.1f;

    public float delayAfterBallLost = 1.0f;
    float ballLostTimer = 0.0f;

    public Ball ball;

    public GameObject basicBlockPrefab;
    public GameObject durableBlockPrefab;
    public GameObject unbreakableBlockPrefab;

    public void BallLost() {
        ballLostTimer = delayAfterBallLost;
    }

    // Use this for initialization
    void Start () {

        // build tiles
        float xInterval = 2 * xFromCenter / (nx - 1);
        float yInterval = (yEnd - yStart) / (ny - 1);

        // build all rows
	    for (int j = 0; j < ny; j++) {
            // build all tiles on row
            for (int i = 0; i < nx; i++) {
                float rnd = Random.value;
                GameObject toBeInstantiated = basicBlockPrefab;
                if (rnd < durableBlockProb) {
                    toBeInstantiated = durableBlockPrefab;
                } else if (rnd < unbreakableBlockProb + durableBlockProb) {
                    toBeInstantiated = unbreakableBlockPrefab;
                }

                var go = Instantiate<GameObject>(toBeInstantiated);
                float newX = -xFromCenter + i * xInterval;
                float newY = yStart + j * yInterval;
                go.transform.position = new Vector3(newX, newY, 0);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        // time delay after ball is lost, so it doesn't reset immediately
        if (ballLostTimer > 0) {
            ballLostTimer -= Time.deltaTime;
            if (ballLostTimer < 0) {
                ball.ResetBall();
            }
        }

	}
}
