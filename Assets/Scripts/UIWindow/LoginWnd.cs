using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginWnd : MonoBehaviour
{
    public InputField acct;
    public InputField pass;
    public Button btnInto;

    // 初始化做的是 玩家的本地账号
    public void InitLogin()
    {
        // 监听按钮(点击则保存账号并且切换到创建角色界面
        btnInto.onClick.AddListener(() => {
            PlayerPrefs.SetString("acct",acct.text);
        });
        
        if (PlayerPrefs.HasKey("acct"))
        {
            acct.text = PlayerPrefs.GetString("acct");
        }
        
    }

    public void OpenLoginWnd()
    {
        gameObject.SetActive(true);
        InitLogin();
    }

}
