using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public GameObject menuUI; // Assign the Canvas here in Inspector
    private bool isPaused = false;

    void Start()
    {
        // Spawn a random cube when the scene loads
        GameObject testCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        testCube.transform.position = new Vector3(
            Random.Range(-5f, 5f), // random X
            1f,                    // fixed Y height
            Random.Range(-5f, 5f)  // random Z
        );

        // Give the cube a random color
        Renderer r = testCube.GetComponent<Renderer>();
        r.material.color = new Color(Random.value, Random.value, Random.value);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) Resume();
            else Pause();
        }
    }

    public void Resume()
    {
        menuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pause()
    {
        menuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
