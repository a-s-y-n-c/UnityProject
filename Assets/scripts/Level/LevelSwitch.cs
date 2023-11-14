using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    public string tagName;
    public string currentScene;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(tagName))
        {
            SceneManager.LoadScene(currentScene);
        }
    }
}
