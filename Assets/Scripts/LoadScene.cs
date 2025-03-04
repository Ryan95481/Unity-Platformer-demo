﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    private AsyncOperation async;

    public void BtnLoadScene()
    {
        if (async == null)
        {
            Scene CurrentScene = SceneManager.GetActiveScene();
            async = SceneManager.LoadSceneAsync(CurrentScene.buildIndex + 1);
            async.allowSceneActivation = true;
        }
    }
    public void BtnLoadScene(int i)
    {
        if (async == null)
        {
            async = SceneManager.LoadSceneAsync(i);
            async.allowSceneActivation = true;
        }
    }

    public void BtnLoadScene(string s)
    {
        if (async == null)
        {
            async = SceneManager.LoadSceneAsync(s);
            async.allowSceneActivation = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
