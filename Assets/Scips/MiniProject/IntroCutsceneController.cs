using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroCutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource bgm;

    void Start()
    {
        videoPlayer.loopPointReached += OnVideoEnd;

        videoPlayer.Play();
        bgm.Play();

        Debug.Log("▶ Intro video & BGM started");
    }


    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("⏭ Intro video finished → Load Gameplay");
        LoadGameplay();
    }


    public void SkipIntro()
    {
        Debug.Log("⏭ Skip button pressed → Load Gameplay");
        LoadGameplay();
    }

    void LoadGameplay()
    {
        bgm.Stop();
        SceneManager.LoadScene("Scene_Gameplay");
    }
}
