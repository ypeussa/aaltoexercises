using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SnakeManager : MonoBehaviour {

    public enum MovementDirection { Up, Right, Down, Left };
    public MovementDirection movementDirection;

    public float tickTime = 1.0f; // seconds
    float timeTowardsNextTick = 0.0f;

    public int currentScore = 0;

    bool growOnNextStep = false;

    bool isGameOver = false;

    // public GameObject snakeBody;
    public List<GameObject> snakeBodies;
    public GameObject food;

    public GameObject snakeBodyPrefab;
    public GameObject highScoreStoragePrefab;

    GameObject highScoreStorage;
    HighScoreStorage highScoreScript;

    public void TriggerGameOver()
    {
        print("Game over!");
        isGameOver = true;
        GameObject.Find("GameOverText").GetComponent<Text>().text = "Game Over!\nPress space to reset";
    }

    void UpdateScoreText() {
        string s = "Score: " + currentScore + " High: " + highScoreScript.highScore;
        GameObject.Find("ScoreText").GetComponent<Text>().text = s;
    }

    void RestartGame() {
        Application.LoadLevel(0);
    }

	// Use this for initialization
	void Start () {
        highScoreStorage = GameObject.Find("HighScoreStorage");
        if (highScoreStorage == null) {
            highScoreStorage = Instantiate<GameObject>(highScoreStoragePrefab);
            highScoreStorage.name = "HighScoreStorage";
        }
        highScoreScript = highScoreStorage.GetComponent<HighScoreStorage>();
        UpdateScoreText();
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.DrawLine(snakeBody.transform.position, food.transform.position, Color.yellow);
        if (Input.GetKeyDown(KeyCode.Space)) {
            RestartGame();
        }

        if (isGameOver)
            return;

        // read input - set next movement direction
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            if (movementDirection != MovementDirection.Down) {
                movementDirection = MovementDirection.Up;
            }
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            if (movementDirection != MovementDirection.Left) {
                movementDirection = MovementDirection.Right;
            }
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            if (movementDirection != MovementDirection.Up) {
                movementDirection = MovementDirection.Down;
            }
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (movementDirection != MovementDirection.Right) {
                movementDirection = MovementDirection.Left;
            }
        }

        timeTowardsNextTick += Time.deltaTime;
        while (timeTowardsNextTick > tickTime) {
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
            growOnNextStep = true;
            
            // move food to new place
            int newXposition = Random.Range(-10, 10);
            int newZposition = Random.Range(-6, 6);
            food.transform.position = new Vector3(newXposition, 0, newZposition);

            // increase score
            currentScore++;
            if (currentScore > highScoreScript.highScore) {
                highScoreScript.highScore = currentScore;
            }
            UpdateScoreText();
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
        if (growOnNextStep) {
            var newSnakeBody = Instantiate<GameObject>(snakeBodyPrefab);
            snakeBodies.Add(newSnakeBody);
            newSnakeBody.transform.position = lastBodyPosition;

            // for project cleanliness, put the new object in a folder
            newSnakeBody.transform.parent = GameObject.Find("SnakeBodies").transform;

            growOnNextStep = false;
        }
    }
}
