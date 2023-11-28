using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;    
using UnityEngine;
using System;

public class Level_Buttons_Switch : MonoBehaviour
{
    public Button level1_Button, level2_Button, level3_Button;
    int levelpassed;

    
    // Start is called before the first frame update
    void Start()
    {
        levelpassed = PlayerPrefs.GetInt("Levelpassed");
        level1_Button.interactable = true;
        level2_Button.interactable = false;
        level3_Button.interactable = false;

        switch (levelpassed)
        {
            case 1:
                level1_Button.interactable = true;
                break;
            
            case 2:
                level2_Button.interactable = true;
                break;
            
            case 3:
                level3_Button.interactable = true;
                break;
                
            
            
            
        }
        
        

    }

    public void levelbeingloaded(int level)
    {
        SceneManager.LoadScene(level);

    }

    public void resetallbuttons()
    {
        level1_Button.interactable = false;
        level2_Button.interactable = false;
        level3_Button.interactable = false;
        PlayerPrefs.DeleteAll();

    }
    
    
    
    
    
// Update is called once per frame
    void Update()
    {
        
        
        
        
        
    }


}
