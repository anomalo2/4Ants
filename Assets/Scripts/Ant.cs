using UnityEngine;
using static UnityEngine.Rendering.BoolParameter;
using System.Collections;

public class Ant : MonoBehaviour
{
    public GameObject ant;
    public GameObject antManager;
    //private GameObject oldAnt;
    public Transform cameraTransform;
    public GameObject antCanvas;
    [SerializeField] private float displayTime = 3f;


    private void Start()
    {
        //oldAnt = antManager.GetComponent<OldAnt>().oldAnt = ant;
    }
    public void HideAnt()
    {
        GameObject oldAnt = antManager.GetComponent<OldAnt>().oldAnt;

        oldAnt.transform.parent.position = new Vector3(cameraTransform.position.x, 0, cameraTransform.position.z);

        ant.SetActive(false);

        oldAnt.SetActive(true);

        oldAnt = ant;
    }

    public void showCanvas()
    {
        StopAllCoroutines();
        antCanvas.SetActive(true);
        StartCoroutine(HideAfterDelay());

    }

    private IEnumerator HideAfterDelay()
    {
        yield return new WaitForSeconds(displayTime);
        antCanvas.SetActive(false);
    }
}
