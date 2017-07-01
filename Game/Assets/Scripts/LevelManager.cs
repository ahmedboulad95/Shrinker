using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	float score = 0.0f;
	int currentLevel = 1;
	int maxLevel = 10;
	int scoreToNextLevel = 2000;
	int multiplier = 10;

	public Text scoreText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (score >= scoreToNextLevel)
			LevelUp ();

		score += Time.deltaTime * multiplier;
		scoreText.text = ((int)score).ToString ();
	}

	void LevelUp()
	{
		
	}
}
