using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveArea : MonoBehaviour
{
    [SerializeField] GameObject ProgressBarUi;
    private ProgressBar progbar;

    private void Start()

    {
        ProgressBarUi.SetActive(false);
        GameObject.FindGameObjectWithTag("GameController").GetComponent<ProgressBar>().hasEnteredCaptureZone = false;
    }
 

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<ProgressBar>().hasEnteredCaptureZone = true;
            ProgressBarUi.SetActive(true);
         
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<ProgressBar>().hasEnteredCaptureZone = false;
            ProgressBarUi.SetActive(false);
        }
    }
}
