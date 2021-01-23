
using UnityEngine;
using UnityEngine.UI;

public class LodingWnd : WindowRoot
{
    public Text tips;
    public Text progress;
    public Image loadingfg;
    public Image point;
    private float Width;
    // 初始化进度条
    public void InitProcess()
    {
        progress.text = "0%";
        loadingfg.fillAmount = 0;
        Width = loadingfg.GetComponent<RectTransform>().sizeDelta.x;
        point.transform.position = new Vector3(-Width/2,0,0);
    }


    // 设置进度位置
    public void setProcess(float val)
    {
        Width =loadingfg.GetComponent<RectTransform>().sizeDelta.x;
        //tips.text = (-Width / 2) + (Width * val) + "正在加载进度";
        SetText(tips, "正在加载进度");
        progress.text = (val * 100) + "%";
        loadingfg.fillAmount = val;
        point.GetComponent<RectTransform>().anchoredPosition = new Vector3((-Width / 2) + (Width * val) , 0, 0); 
    }
}
