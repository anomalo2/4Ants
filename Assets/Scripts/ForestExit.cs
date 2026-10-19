using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestExit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("ForestFinal");
        }
    }
}