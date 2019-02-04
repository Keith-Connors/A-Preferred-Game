using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform LoadingBar;
    public Transform TextPercentage;
    public Transform TextLoading;
    [SerializeField] Transform WrldLoadingBar,WrldTextPercentage, WrldTextLoading;

    public float m_loadAmount;
    public float m_loadSpeed;

    public bool hasEnteredCaptureZone;
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (player.gameObject.tag == "Player")
        {
            if (m_loadAmount < 100)
            {
                m_loadAmount += m_loadSpeed * Time.deltaTime;
                TextPercentage.GetComponent<Text>().text = ((int)m_loadAmount).ToString() + "%";
                TextLoading.gameObject.SetActive(true);
            }
            else
            {

                TextLoading.gameObject.SetActive(false);
            }
            LoadingBar.GetComponent<Image>().fillAmount = m_loadAmount / 100;
        }*/

        //When the Player enters the trigger, set the boolean to true.
    /*    if (other.tag == "Player")
        {
            hasEnteredCaptureZone = true;
        }
     
    }
    */
    
   /*
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            hasEnteredCaptureZone = false;
            Debug.Log("player has exited");
        }

    }
    */

    private void Update()
    {
        if (hasEnteredCaptureZone == true && m_loadAmount < 100)
        {
            m_loadAmount += m_loadSpeed * Time.deltaTime;
            TextPercentage.GetComponent<Text>().text = ((int)m_loadAmount).ToString() + "%";
            WrldTextPercentage.GetComponent<Text>().text = ((int)m_loadAmount).ToString() + "%";
            TextLoading.gameObject.SetActive(true);
            WrldTextLoading.gameObject.SetActive(true);
        }
        else
        {
            TextPercentage.gameObject.SetActive(true);
            WrldTextPercentage.gameObject.SetActive(true);
            TextLoading.GetComponent<Text>().text = "Captured";
            WrldTextLoading.GetComponent<Text>().text = "Captured";
            // TextLoading.gameObject.SetActive(false);
        }
        if (hasEnteredCaptureZone == false && m_loadAmount <= 100)
        {
            if(m_loadAmount < 0)
            {
                m_loadAmount = 0;
            }

            m_loadAmount -= m_loadSpeed * Time.deltaTime;
        }
        LoadingBar.GetComponent<Image>().fillAmount = m_loadAmount / 100;
        WrldLoadingBar.GetComponent<Image>().fillAmount = m_loadAmount / 100;
    }
}
