using UnityEngine;
using System.Collections;

public class SnakeManager : MonoBehaviour {

    public enum MovementDirection { Up, Right, Down, Left };
    public MovementDirection movementDirection;

    public float tickTime = 1.0f; // seconds
    float timePassed = 0.0f;

    public GameObject snakeBody;
    public GameObject food;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawLine(snakeBody.transform.position, food.transform.position, Color.yellow);

        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            movementDirection = MovementDirection.Up;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            movementDirection = MovementDirection.Right;
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            movementDirection = MovementDirection.Down;
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            movementDirection = MovementDirection.Left;
        }

        timePassed += Time.deltaTime;
        if (timePassed > tickTime) {
            print("Run some game logic");
            MoveSnake();
            MaybeEatFood();
            timePassed -= tickTime;
        }
	}

    void MaybeEatFood()
    {
        // check if snake is on top of food

        if (Vector3.Distance(snakeBody.transform.position, food.transform.position) < Mathf.Epsilon)
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
        if (movementDirection == MovementDirection.Up) {
            snakeBody.transform.position += new Vector3(0, 0, 1); // Vector3.forward
        } else if (movementDirection == MovementDirection.Right) {
            snakeBody.transform.position += new Vector3(1, 0, 0); // Vector3.right
        } else if (movementDirection == MovementDirection.Down) {
            snakeBody.transform.position += new Vector3(0, 0, -1); // -Vector3.forward
        } else { // left
            snakeBody.transform.position += new Vector3(-1, 0, 0); // -Vector3.right
        }
    }
}
