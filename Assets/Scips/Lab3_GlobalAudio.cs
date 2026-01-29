using UnityEngine;

public class GlobalAudioManager : MonoBehaviour
{
    public AudioSource musicSource;

    private bool isMuted = false;
    private bool isPaused = false;
    private float defaultVolume;

    void Start()
    {
        if (musicSource != null)
            defaultVolume = musicSource.volume;
    }

    void Update()
    {
        // M: Tắt / bật âm nhạc
        if (Input.GetKeyDown(KeyCode.M))
        {
            isMuted = !isMuted;

            if (musicSource != null)
            {
                musicSource.volume = isMuted ? 0f : defaultVolume;
            }

            Debug.Log(isMuted
                ? "🔇 Music Muted"
                : "🔊 Music Unmuted");
        }

        // P: Pause / Resume nhạc
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPaused = !isPaused;

            if (musicSource != null)
            {
                if (isPaused)
                    musicSource.Pause();
                else
                    musicSource.UnPause();
            }

            Debug.Log(isPaused
                ? "⏸ Music Paused"
                : "▶ Music Resumed");
        }
    }
}
