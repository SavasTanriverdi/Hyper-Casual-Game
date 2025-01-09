using System;
using UnityEngine;

public class FalseVideo : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayer; // videoPlayer, videoyu temsil eder

    private void Awake()
    {
        videoPlayer.SetActive(false); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
    }
}
