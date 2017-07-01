﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public void PlayButtonClick()
	{
		SceneManager.LoadScene ("GameScene");
	}

	public void OptionsButtonClick()
	{
		SceneManager.LoadScene ("OptionsScene");
	}
}
