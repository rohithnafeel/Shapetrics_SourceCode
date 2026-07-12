using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlayButton();
        }

        SceneManager.LoadScene("GameScene");
    }

    public void ExitGame()
    {
        if (AudioManager.Instance != null)
        {
            AudioManager.Instance.PlayButton();
        }

        Invoke(nameof(Quit), 0.2f);
    }

    void Quit()
    {
        Application.Quit();
    }
}