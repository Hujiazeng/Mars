using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 资源服务
public class ResSrv : MonoBehaviour
{
    public static ResSrv Instance = null;
    private float progress;
    private Action func;
    public void InitResSrv()
    {
        Instance = this;
        Debug.Log("ResSrv init ....");
    }

    // 用字典做缓存, 存储音乐
    private Dictionary<string, AudioClip> musicCache = new Dictionary<string, AudioClip>();
    // 加载音乐资源
    public AudioClip LoadAudio(string name, bool cache = false)
    {
        AudioClip audio = null;
        if (!musicCache.TryGetValue(name, out audio))
        {
            audio = Resources.Load<AudioClip>("ResAudio/" + name);
            if (cache)
            {
               
                musicCache.Add(name, audio);
            }
        }else { Debug.Log("Get From Cache!");}
        return audio;
    }


    // 异步加载资源
    public void AsyncLoadScene(string sceneName, Action nextFunc)
    {
        AsyncOperation asyncRes = SceneManager.LoadSceneAsync(sceneName);
        func = () =>
        {
            progress = asyncRes.progress;
            GameRoot.Instance.lodingWnd.setProcess(progress);
            // 加载完成关闭 (关闭意味着打开新场景, 传入回调更通用)
            if (progress == 1)
            {
                if (nextFunc != null)
                {
                    nextFunc();
                }
                func = null;
                asyncRes = null;
                GameRoot.Instance.lodingWnd.gameObject.SetActive(false);
            }

        };
        

    }

    // 需要实时的记录变化进度
    private void Update()
    {
        // 相当于一个for循环不停的在执行,让其执行方法
        if (func != null)
        {
            func();
        }

    }


    



}
