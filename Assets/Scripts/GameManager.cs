using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject SettingsPanel;
    public GameObject GameOverPenel;
  
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    
    void Update()
    {
        if (SettingsPanel.activeSelf == true)
        {
            GameOverPenel.SetActive(false);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void SettingsPanelKapat()
    {
        if(Time.timeScale <= 0)
        {
            RestartGame();
        }
        SettingsPanel.SetActive(false);
    }
}
