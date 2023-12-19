using UnityEngine;
using UnityEngine.SceneManagement;


public class Screen_transtion : MonoBehaviour
{
    public string nextScene;
    public Animator close_animator;
    public Animator open_animator;
    
    // Start is called before the first frame update
    void Start()
    {
        close_animator = GetComponent<Animator>();
        open_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            open_animator.SetTrigger("Screen_Open_Trigger");
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}







