using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadDriving()
    {
        Debug.Log("Driving Game clicked");
        Time.timeScale = 1f;
        SceneManager.LoadScene("DrivingScene");
    }

    public void LoadFlying()
    {
        Debug.Log("Flying Game clicked");
        Time.timeScale = 1f;
        SceneManager.LoadScene("FlyingScene");
    }

    public void LoadSumo()
    {
        Debug.Log("Sumo Game clicked");
        Time.timeScale = 1f;
        SceneManager.LoadScene("SumoScene");
    }

    public void ExitGame()
    {
        Debug.Log("Exit clicked");
        Application.Quit();
    }
}
