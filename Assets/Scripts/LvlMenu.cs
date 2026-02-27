using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlMenu : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("World Map 1");
    }

    public void Go()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Go2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Go3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Go4()
    {
        SceneManager.LoadScene("Level 4");
    }

       public void Back2()
    {
        SceneManager.LoadScene("World Map 2");
    }

       public void Back3()
    {
        SceneManager.LoadScene("World Map 3");
    }

       public void Back4()
    {
        SceneManager.LoadScene("World Map 4");
    }
}
