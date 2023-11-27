using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string newScene;

	public void switchScene() {
		SceneManager.LoadScene(newScene);
	}
}

