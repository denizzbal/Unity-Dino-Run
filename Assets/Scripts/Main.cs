using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Image StoryPanelImage;
    float t = 0;
    float duration = 1f;
    private void Start()
    {
        StoryPanelImage.color = new Color(0f, 0f, 0f, 0f);
        StoryPanelImage.gameObject.SetActive(false);
    }
    public void RunGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StoryAc()
    {
        StartCoroutine(StoryPanelAc());
    }

    public void StoryKapat()
    {
        StartCoroutine(StoryPanelKapat());
    }

    IEnumerator StoryPanelKapat()
    {
        while (t > 0f) 
        {
            t -= Time.deltaTime / duration;
            StoryPanelImage.color = new Color(0f, 0f, 0f, t);
            yield return null;

            if(t <= 0)
            {
                StoryPanelImage.gameObject.SetActive(false);
            }
        }

    }

    IEnumerator StoryPanelAc()
    {
        while (t < 1f)
        {
            StoryPanelImage.gameObject.SetActive(true);
            t += Time.deltaTime / duration;
            StoryPanelImage.color = new Color(0f, 0f, 0f, t);
            yield return null;
        }

    }
}
