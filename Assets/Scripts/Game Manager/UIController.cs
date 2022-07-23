using System;
using System.Collections;
using System.Collections.Generic;
using Game_Manager;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject playButton;
    [SerializeField] private GameObject playButtonBackground;

    public static UIController Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void PlayGameUI()
    {
        Time.timeScale = 1f;
        playButton.SetActive(false);
        playButtonBackground.SetActive(false);
    }
}
