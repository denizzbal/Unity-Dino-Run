using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public Image LoadingBarFill;
    float t = 0;
    float duration = 2f; 
    void Start()
    {
        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        //AsyncOperation operation = SceneManager.LoadSceneAsync(2);
        //while (!operation.isDone)
        //{
        //    float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
        //    LoadingBarFill.fillAmount = progressValue;
        //    yield return null;
        //}
        

        while (t < 1)
        {
            t += Time.deltaTime / duration;
            LoadingBarFill.fillAmount = Mathf.Lerp(0f, 1.0f, t);
            yield return null;         
        }
        AsyncOperation operation = SceneManager.LoadSceneAsync(2);
    }
}
