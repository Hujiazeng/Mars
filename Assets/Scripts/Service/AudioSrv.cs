using UnityEngine;


//  **********************
//  Function :   音乐服务  
//  **********************



public class AudioSrv : MonoBehaviour

{
    // 挂载背景和音乐两个模块的管理
    public AudioSource UIAudio;
    public AudioSource BGAudio;

    public static AudioSrv Instance = null;
    public void InitSrc()
    {
        Instance = this;
        Debug.Log("AudioSrc Init...");
    }


    // 控制组件播放音乐
    public void PlayBGMusic(string name, bool isLoop = true)
    {
        AudioClip audio = ResSrv.Instance.LoadAudio(name, true);
        // 如果当前音乐为空,或者当前音乐名和新加载的音乐名不同,说明要更换音乐
        if (audio!=null && (BGAudio.clip == null || BGAudio.clip.name != audio.name))
        {
            BGAudio.clip = audio;
            BGAudio.loop = isLoop;
            BGAudio.Play();
        }
    }
    

}
