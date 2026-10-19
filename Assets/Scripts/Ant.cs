using UnityEngine;

public class Ant : MonoBehaviour
{
    public GameObject ant;
    public GameObject oldAnt;

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
