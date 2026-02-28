using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scene1");
    }

    public void Shop()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Shop");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
