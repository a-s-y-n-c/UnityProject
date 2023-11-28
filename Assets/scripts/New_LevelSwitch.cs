using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class New_LevelSwitch : MonoBehaviour
{
    public static Level_Buttons_Switch instance = null;
    GameObject triangle;
    int sceneindex, Levelpassed;
    
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {

        triangle = GameObject.Find ("Triangle(1)");

        sceneindex = SceneManager.GetActiveScene().buildIndex;
        Levelpassed = PlayerPrefs.GetInt("Levelpassed");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
