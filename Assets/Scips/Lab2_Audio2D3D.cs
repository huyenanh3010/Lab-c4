using UnityEngine;

public class SoundEmitter2D3D : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource.Play();
        Debug.Log("▶ Audio started");
    }

    void Update()
    {
        // Bấm 1 → Audio 2D
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            audioSource.spatialBlend = 0f;
            Debug.Log("🔊 Switched to 2D Audio");
        }

        // Bấm 2 → Audio 3D
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            audioSource.spatialBlend = 1f;
            Debug.Log("🔊 Switched to 3D Audio");
        }
    }
}
