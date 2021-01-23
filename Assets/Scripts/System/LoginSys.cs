using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 登陆系统

public class LoginSys : MonoBehaviour
{
    public static LoginSys Instance = null;
    public void InitLoginSys()
    {
        Instance = this;
        Debug.Log("LoginSys init...");
    }


    // 进入登陆场景
    public void EnterLogin()
    {
        // 展示加载界面, 此时异步加载登陆资源(并设置进度条,加载完毕后进入登陆界面并初始化信息)
        GameRoot.Instance.lodingWnd.gameObject.SetActive(true);
        GameRoot.Instance.lodingWnd.InitProcess();
     
        ResSrv.Instance.AsyncLoadScene(Constants.SceneLogin, GameRoot.Instance.loginWnd.OpenLoginWnd);

        // 播放音乐
        AudioSrv.Instance.PlayBGMusic(Constants.BgLogin);

        


    }
}
