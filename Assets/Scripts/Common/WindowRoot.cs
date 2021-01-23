using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// 窗口基类(继承可直接调用)
public class WindowRoot : MonoBehaviour
{
    public void SetWndState(bool isActive = true)
    {
        // 设置窗口状态(先判断状态是否需要操作)
        if (gameObject.activeSelf != isActive)
        {
            gameObject.SetActive(isActive);
        }

        // 如果窗口激活需要初始化模块
        if (isActive)
        {
            InitWnd();
        }
        else
        {
            ClearWind();
        }
    }

    public virtual void InitWnd()
    {
        // 每个窗口都需要初始化

    }

    public virtual void ClearWind()
    {
        // 每个窗口都需要关闭

    }



    // 设置文本内容
    protected void SetText(Text t, string content="")
    {
        // 传入字符串
        t.text = content;
    }

    protected void SetText(Text t, int num = 0)
    {
        // 传入数字时
        SetText(t, num.ToString());
    }

    protected void SetText(Transform trans, string content = "")
    {
        // 传入组件时
        SetText(trans.GetComponent<Text>(), content);
    }
    protected void SetText(Transform trans, int num = 0)
    {
        SetText(trans.GetComponent<Text>(), num);
    }



    // 激活组件
    protected void SetActive(GameObject g, bool isActive = true)
    {
        g.SetActive(isActive);
    }

    protected void SetActive(Transform g, bool isActive = true)
    {
        g.gameObject.SetActive(isActive);
    }
    protected void SetActive(RectTransform g, bool isActive = true)
    {
        g.gameObject.SetActive(isActive);
    }
    protected void SetActive(Image g, bool isActive = true)
    {
        g.transform.gameObject.SetActive(isActive);
    }
    protected void SetActive(Text g, bool isActive = true)
    {
        g.transform.gameObject.SetActive(isActive);
    }

}
