using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void anamenu()
    {
        SceneManager.LoadScene(0);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    public void taratma()
    {
        SceneManager.LoadScene(1);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    public void foto()
    {
        SceneManager.LoadScene(17);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    public void boyama()
    {
        SceneManager.LoadScene(18);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    public void degerlendirme()
    {
        SceneManager.LoadScene(9);
        Screen.orientation = ScreenOrientation.Portrait;

    }
    public void inek()
    {
        SceneManager.LoadScene(4);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void kaktüs()
    {
        SceneManager.LoadScene(5);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void pisa()
    {
        SceneManager.LoadScene(6);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    } 
    public void tacmahal()
    {
        SceneManager.LoadScene(7);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void sapka()
    {
        SceneManager.LoadScene(8);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void pizza()
    {
        SceneManager.LoadScene(10);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void el()
    {
        SceneManager.LoadScene(27);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void fil()
    {
        SceneManager.LoadScene(26);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void kadýn()
    {
        SceneManager.LoadScene(29);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void spagetti()
    {
        SceneManager.LoadScene(24);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void kano()
    {
        SceneManager.LoadScene(21);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void kýzcocuk()
    {
        SceneManager.LoadScene(22);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void biber()
    {
        SceneManager.LoadScene(28);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void gitar()
    {
        SceneManager.LoadScene(23);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void piramit()
    {
        SceneManager.LoadScene(25);
        Screen.orientation = ScreenOrientation.LandscapeLeft;

    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }


}