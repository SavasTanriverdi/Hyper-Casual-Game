using System;
using UnityEngine;

public class FalseHyperCasual : MonoBehaviour
{
    [SerializeField] private GameObject confetti1;
    [SerializeField] private GameObject confetti2;
    [SerializeField] private GameObject confetti3;
    [SerializeField] private GameObject confetti4;
    [SerializeField] private GameObject confetti5;
    [SerializeField] private GameObject confetti6;
    [SerializeField] private GameObject confetti7;
    [SerializeField] private GameObject confetti8;
    [SerializeField] private GameObject confetti9;
    [SerializeField] private GameObject confetti10;
    [SerializeField] private GameObject confetti11;

    private void Awake()
    {
        confetti1.SetActive(false);
        confetti2.SetActive(false);
        confetti3.SetActive(false);
        confetti4.SetActive(false);
        confetti5.SetActive(false);
        confetti6.SetActive(false);
        confetti7.SetActive(false);
        confetti8.SetActive(false);
        confetti9.SetActive(false);
        confetti10.SetActive(false);
        confetti11.SetActive(false);
    }
}
