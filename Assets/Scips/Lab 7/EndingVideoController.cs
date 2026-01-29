using UnityEngine;
using UnityEngine.Video;

public class EndingVideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject endCanvas;

    void Start()
    {
        endCanvas.SetActive(false);

        videoPlayer.prepareCompleted += OnPrepared;
        videoPlayer.loopPointReached += OnVideoEnd;

        videoPlayer.Prepare();
        Debug.Log("🎬 Preparing Ending Video...");
    }

    void OnPrepared(VideoPlayer vp)
    {
        vp.Play();
        Debug.Log("▶ Playing Ending Video");
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("✅ Ending video finished → Show UI");
        endCanvas.SetActive(true);
    }
}

