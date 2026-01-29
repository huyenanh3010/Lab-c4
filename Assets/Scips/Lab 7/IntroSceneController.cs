using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class IntroSceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nextSceneName = "EndScene";

    void Start()
    {
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        Debug.Log("🎬 [Intro] Preparing video...");
        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("▶️ [Intro] Video prepared → Playing");
        videoPlayer.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("🔁 [Intro] Video finished → Load EndScene");
        SceneManager.LoadScene(nextSceneName);
    }
}
