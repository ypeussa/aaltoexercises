using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeManager : MonoBehaviour {

    public enum MovementDirection { Up, Right, Down, Left };
    public MovementDirection movementDirection;

    public float tickTime = 1.0f; // seconds
    float timeTowardsNextTick = 0.0f;

    // public GameObject snakeBody;
    public List<GameObject> snakeBodies;
    public GameObject food;

    public void TriggerGameOver()
    {
        print("Game over!");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.DrawLine(snakeBody.transform.position, food.transform.position, Color.yellow);

        // read input - set next movement direction
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            movementDirection = MovementDirection.Up;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            movementDirection = MovementDirection.Right;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            movementDirection = MovementDirection.Down;
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            movementDirection = MovementDirection.Left;
        }

        timeTowardsNextTick += Time.deltaTime;
        if (timeTowardsNextTick > tickTime) {
            print("Run some game logic");
            MoveSnake();
            MaybeEatFood();
            timeTowardsNextTick -= tickTime;
        }
	}

    void MaybeEatFood()
    {
        // check if snake is on top of food

        if (Vector3.Distance(snakeBodies[0].transform.position, food.transform.position) < Mathf.Epsilon)
        {
            print("EATING");
            // grow snake body
            // move food to new place

            int newXposition = Random.Range(-10, 10);
            int newZposition = Random.Range(-6, 6);
            food.transform.position = new Vector3(newXposition, 0, newZposition);
            
            // increase score
        }
        // eat food if yes
    }

    void MoveSnake()
    {
        Vector3 lastBodyPosition = snakeBodies[0].transform.position;
        if (movementDirection == MovementDirection.Up) {
            snakeBodies[0].transform.position += new Vector3(0, 0, 1); // Vector3.forward
        } else if (movementDirection == MovementDirection.Right) {
            snakeBodies[0].transform.position += new Vector3(1, 0, 0); // Vector3.right
        } else if (movementDirection == MovementDirection.Down) {
            snakeBodies[0].transform.position += new Vector3(0, 0, -1); // -Vector3.forward
        } else { // left
            snakeBodies[0].transform.position += new Vector3(-1, 0, 0); // -Vector3.right
        }
        
        for (int i=1; i<snakeBodies.Count; i++)
        {
            Vector3 temp = lastBodyPosition;
            lastBodyPosition = snakeBodies[i].transform.position;
            snakeBodies[i].transform.position = temp;
        }
    }
}
