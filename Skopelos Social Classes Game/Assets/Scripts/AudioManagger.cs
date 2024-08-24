using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;
    private AudioSource audioSource;
    private bool isPlaying = true;

    void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            // This is the first instance, set it as the singleton
            instance = this;
            DontDestroyOnLoad(gameObject); // Prevents this object from being destroyed on scene load
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            // Destroy this instance if another one already exists
            Destroy(gameObject);
        }
    }

    public void PlayMusic()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
            isPlaying = true;
        }
    }

    public void PauseMusic()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
        }
    }

    public void ToggleMusic()
    {
        if (isPlaying)
        {
            PauseMusic();
        }
        else
        {
            PlayMusic();
        }
    }

    // Provide a way to access the singleton instance
    public static AudioManager Instance
    {
        get
        {
            // If the instance is null, try to find one in the scene
            if (instance == null)
            {
                instance = FindObjectOfType<AudioManager>();
            }
            return instance;
        }
    }
}
