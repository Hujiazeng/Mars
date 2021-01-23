using UnityEngine;


//  **********************
//  Function :  业务系统基类
//  **********************



public class SystemRoot : MonoBehaviour

{
    // 避免写类.instance

    protected ResSrv ResSrv;
    protected LoginSys LoginSys;
    protected AudioSrv res;
    public virtual void InitSys()
    {
        ResSrv = ResSrv.Instance;
        LoginSys = LoginSys.Instance;
        res = AudioSrv.Instance;
    }
    

}
