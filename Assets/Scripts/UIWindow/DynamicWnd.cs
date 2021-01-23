using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//  **********************
//  Function :     
//  **********************



public class DynamicWnd : WindowRoot

{
    public Text txt;
    public Animation ani;
    // tips弹窗

    private void InitDynamicWnd()
    {
        SetActive(txt, false);

    }

    public void SetTips(string content)
    {
        SetText(txt, content);
        SetActive(txt, true);
        // 获取tips动画, 等待tips动画完成后关闭
        AnimationClip c = ani.GetClip("TipsShowAni");
        ani.Play();

        // 使用协程(定时关闭)状态     因为非阻塞的
        StartCoroutine(AniPlayDone(c.length, () => {
            SetActive(txt, false);
        }));

    }

    // 延迟关闭函数
    private IEnumerator AniPlayDone(float s, Action func)
    {
        yield return new WaitForSeconds(s);
        if (func != null)
        {
            func();
        }
    }






    

}
