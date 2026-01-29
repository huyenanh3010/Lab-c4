using UnityEngine;

public class Lab4_AudioTest : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    [Header("SFX Settings")]
    public float sfxVolume = 1f;

    void Start()
    {
        if (bgmSource != null)
        {
            bgmSource.Play();
            Debug.Log("🎵 BGM started (Streaming / Vorbis)");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySFX();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            ToggleBGM();
        }
    }

    void PlaySFX()
    {
        if (sfxSource != null && sfxSource.clip != null)
        {
            sfxSource.PlayOneShot(sfxSource.clip, sfxVolume);
            Debug.Log("🔊 SFX played (Multiple / No delay)");
        }
        else
        {
            Debug.LogWarning("⚠️ SFX Source hoặc Clip chưa được gán!");
        }
    }

    void ToggleBGM()
    {
        if (bgmSource == null) return;

        if (bgmSource.isPlaying)
        {
            bgmSource.Pause();
            Debug.Log("⏸️ BGM Paused");
        }
        else
        {
            bgmSource.Play();
            Debug.Log("▶️ BGM Resumed");
        }
    }
}
