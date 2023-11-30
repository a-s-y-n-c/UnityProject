using UnityEngine;
using UnityEngine.SceneManagement;


public class Screen_transtion : MonoBehaviour
{
    public string nextScene;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("changeScene");
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}







