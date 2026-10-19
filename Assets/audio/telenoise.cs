using UnityEngine;

public class telenoise : MonoBehaviour
{
    public Vector3 targetPosition;
    private UserNoise userNoise;

    private void Awake()
    {
        userNoise = GetComponent<UserNoise>();
    }

    public void ExecuteTeleport()
    {
        // Move player
        transform.position = targetPosition;

        // Play sound
        if (userNoise != null)
        {
            userNoise.PlayTeleportSound();
        }
    }
}