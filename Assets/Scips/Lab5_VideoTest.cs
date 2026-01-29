using UnityEngine;
using UnityEngine.Video;
using TMPro;

public class Lab5_VideoTest : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public TextMeshProUGUI logText;

    void Start()
    {
        if (logText != null)
            logText.text = "Press V to play video";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (videoPlayer != null)
            {
                videoPlayer.Play();

                Debug.Log("🎬 [LOG] Pressed V → Video is playing");

                if (logText != null)
                    logText.text = "🎬 Video is playing...";
            }
            else
            {
                Debug.LogWarning("⚠️ VideoPlayer chưa được gán!");

                if (logText != null)
                    logText.text = "⚠️ VideoPlayer not assigned!";
            }
        }
    }
}
