using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenResolution : MonoBehaviour
{
    static GameObject Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else if(gameObject != Instance)
        {
            Destroy(gameObject);
        }

        
    }

    void Start()
    {
        Screen.SetResolution(Screen.currentResolution.width / 2, Screen.currentResolution.height / 2, true);
        //QualitySettings.SetQualityLevel(1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
