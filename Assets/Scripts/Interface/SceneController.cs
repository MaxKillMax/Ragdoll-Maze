using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.HasKey("Scene") == false)
        {
            PlayerPrefs.SetInt("Scene", 0);
        }
    }

    public void ReturnToMenu()
    {
        PlayerPrefs.SetInt("Scene", 0);
        SceneManager.LoadScene(0);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Scene"));
    }

    public void StartGame(int sceneIndex)
    {
        PlayerPrefs.SetInt("Scene", sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }
}
