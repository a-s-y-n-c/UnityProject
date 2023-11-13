using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    private Scene currentScene;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        SceneManager.LoadScene(currentScene.name);
    }
}
