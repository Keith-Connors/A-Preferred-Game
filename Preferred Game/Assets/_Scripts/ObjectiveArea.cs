using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveArea : MonoBehaviour
{
    [SerializeField] GameObject ProgressBarUi;

    private void Start()
    {
        ProgressBarUi.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player Entered");
            ProgressBarUi.SetActive(true);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Left");
            ProgressBarUi.SetActive(false);
        }
    }
}
