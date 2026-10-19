using UnityEngine;

public class Ant : MonoBehaviour
{
    public GameObject ant;
    public GameObject antManager;
    private GameObject oldAnt;


    private void Start()
    {
        oldAnt = antManager.GetComponent<OldAnt>().oldAnt = ant;
    }
    public void HideAnt()
    {

        ant.SetActive(false);
        oldAnt.SetActive(true);

        oldAnt = ant;
    }
}
