﻿using UnityEngine;
using System.Collections;

public class HighScoreStorage : MonoBehaviour {
    public int highScore;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
	}
}
