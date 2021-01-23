
using UnityEngine;
// 游戏启动入口

public class GameRoot : MonoBehaviour
    // 挂载在GameRoot上, 运行会自动执行该脚本
{   
    public LodingWnd lodingWnd;
    public CreateWnd createWnd;
    public LoginWnd loginWnd;
    public DynamicWnd DynamicWnd;
    public static GameRoot Instance = null;
    
    private void Start()
    {
        Instance = this;
        DontDestroyOnLoad(this);
        Debug.Log("Game Start...");
        Init();
    }

    private void Init()
    {
        // --------初始化--------

        //初始化资源服务
        ResSrv res = GetComponent<ResSrv>();
        res.InitResSrv();
        //初始化登陆业务系统
        LoginSys Login = GetComponent<LoginSys>();
        Login.InitLoginSys();
        // 初始化播放音乐服务
        AudioSrv Audio = GetComponent<AudioSrv>();
        Audio.InitSrc();


        // -------进入登陆界面------
        Login.EnterLogin();

        // 显示弹窗
        DynamicWnd.SetTips("Tips已完成, 该去洗漱准备睡觉了");






    }


}
