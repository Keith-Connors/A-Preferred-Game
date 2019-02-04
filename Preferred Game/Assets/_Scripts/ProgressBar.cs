﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Transform LoadingBar;
    public Transform TextPercentage;
    public Transform TextLoading;

    public float m_loadAmount;
    [SerializeField] float m_loadSpeed;

    bool hasEnteredCaptureZone;

    private void OnTriggerEnter(Collider player)
    {/*
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
        hasEnteredCaptureZone = true;
    }

    private void OnTriggerExit(Collider player)
    {
        hasEnteredCaptureZone = false;
    }

    private void Update()
    {
        if (hasEnteredCaptureZone = true && m_loadAmount < 100)
        {
            m_loadAmount += m_loadSpeed * Time.deltaTime;
            TextPercentage.GetComponent<Text>().text = ((int)m_loadAmount).ToString() + "%";
            TextLoading.gameObject.SetActive(true);
        }
        else
        {
            TextPercentage.gameObject.SetActive(false);
            TextLoading.GetComponent<Text>().text = "Captured";
            // TextLoading.gameObject.SetActive(false);
        }
        LoadingBar.GetComponent<Image>().fillAmount = m_loadAmount / 100;
    }
}
