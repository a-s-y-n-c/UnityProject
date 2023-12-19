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
            StartCoroutine("LoadLevel");
        }
    }

    IEnumerator LoadLevel()
    {
        Animator closingAnim = GameObject.Find("Screen Closing Animation").GetComponent<Animator>();
        if (closingAnim == null)
        {
            Debug.Log(gameObject.name + "'s LevelSwitch script could not find closing scene animator. ERROR!!!");
        }
        closingAnim.SetTrigger("Screen_Closed_Trigger");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(currentScene);
    }

}
