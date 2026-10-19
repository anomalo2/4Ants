using UnityEngine;

public class Ant : MonoBehaviour
{
    public GameObject ant;

    public void HideAnt()
    {
        if (ant.activeInHierarchy)
        {
            ant.SetActive(false);
        }
        else
        {
            ant.SetActive(true);
        }
    }
}
