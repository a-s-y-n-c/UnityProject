using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string newScene;

	public void switchScene() {
		StartCoroutine("LoadLevel");
		
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
		SceneManager.LoadScene(newScene);
	}
}

