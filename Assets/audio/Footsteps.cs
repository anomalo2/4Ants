using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Footsteps : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip footstepClip;
    [Range(0f, 1f)] public float volume = 1f;
    public float pitchVariation = 0.05f;

    [Header("Movement")]
    public Transform trackedTransform;
    public float stepDistance = 0.7f;
    public float maxSpeed = 6f;

    private AudioSource audioSource;
    private Vector3 lastPosition;
    private float distanceAccumulated;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
    }

    private void Start()
    {
        if (trackedTransform == null && Camera.main != null)
            trackedTransform = Camera.main.transform;

        if (trackedTransform != null)
            lastPosition = trackedTransform.position;
    }

    private void Update()
    {
        if (trackedTransform == null || footstepClip == null) return;

        // Only horizontal movement counts (ignore head bobbing up/down)
        Vector3 current = trackedTransform.position;
        Vector3 delta = current - lastPosition;
        delta.y = 0f;
        lastPosition = current;

        float speed = delta.magnitude / Mathf.Max(Time.deltaTime, 0.0001f);

        // Skip teleports / sudden jumps
        if (speed > maxSpeed) return;

        distanceAccumulated += delta.magnitude;

        if (distanceAccumulated >= stepDistance)
        {
            distanceAccumulated = 0f;
            PlayStep();
        }
    }

    private void PlayStep()
    {
        audioSource.pitch = 1f + Random.Range(-pitchVariation, pitchVariation);
        audioSource.PlayOneShot(footstepClip, volume);
    }
}