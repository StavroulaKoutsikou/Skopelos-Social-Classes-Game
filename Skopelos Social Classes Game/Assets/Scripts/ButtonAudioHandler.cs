using UnityEngine;
using UnityEngine.UI;

public class ButtonAudioHandler : MonoBehaviour
{
    public AudioClip buttonClickSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false; // Set to false to control playback manually
        audioSource.clip = buttonClickSound;
    }

    public void PlayButtonClickSound()
    {
        if (audioSource != null && buttonClickSound != null)
        {
            audioSource.PlayOneShot(buttonClickSound);
        }
    }

    public void OnButtonClick()
    {
        PlayButtonClickSound();
        // Use the singleton instance to toggle music
        AudioManager.Instance.ToggleMusic();
    }
}
