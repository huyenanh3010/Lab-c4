using UnityEngine;
using UnityEngine.Video;

public class Lab6_VideoTest : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            videoPlayer.Play();
            Debug.Log("🎬 Video played via RenderTexture (UI RawImage)");
        }
    }
}
