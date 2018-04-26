using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{
    bool pause = false;
    public void ScenceChangeGame(string NameScence)
    {
        Application.LoadLevel(NameScence);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ScenceMenu(string NameScence)
    {
        Application.LoadLevel(NameScence);
    }
    static public void GameOver(int NumberScence)
    {
        //Application.LoadLevel(NumberScence);
        SceneManager.LoadScene(NumberScence);
    }
    static public void LevelMap(string NameScence)
    {
        Application.LoadLevel(NameScence);
    }
    void Update()
    {
        if (Input.GetKeyDown("escape") && pause==false)
        {
            Time.timeScale = 0;
            pause = true;
        }
        else if(Input.GetKeyDown("escape") && pause==true)
        {
            Time.timeScale = 1;
            pause = false;
        }
    }
}
