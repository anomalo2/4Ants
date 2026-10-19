using UnityEngine;

public class UserNoise : MonoBehaviour
{
    public AudioClip startupSound;
    public AudioClip teleportSound;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    private void Start()
    {
        if (startupSound != null)
        {
            audioSource.PlayOneShot(startupSound);
        }
    }

    public void PlayTeleportSound()
    {
        if (teleportSound != null)
        {
            audioSource.PlayOneShot(teleportSound);
        }
    }
}