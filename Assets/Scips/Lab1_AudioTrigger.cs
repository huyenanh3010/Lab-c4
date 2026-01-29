using UnityEngine;

public class Lab1_AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            Debug.Log("▶ Space pressed → Audio Play");
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
            Debug.Log("⏹ S pressed → Audio Stop");
        }
    }
}
