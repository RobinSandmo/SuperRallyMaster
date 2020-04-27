
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndMenu : MonoBehaviour {


    public void PlayGame()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitMenu() 
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}