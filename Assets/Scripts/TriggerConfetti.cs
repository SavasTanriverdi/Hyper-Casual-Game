using UnityEngine;

public class TriggerConfetti : MonoBehaviour
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

    private void OnTriggerEnter(Collider other) // OnTriggerEnter, bir tetikleyiciye başka bir nesne girdiğinde çalışır
    {
        confetti1.SetActive(true);
        confetti2.SetActive(true);
        confetti3.SetActive(true);
        confetti4.SetActive(true);
        confetti5.SetActive(true);
        confetti6.SetActive(true);
        confetti7.SetActive(true);
        confetti8.SetActive(true);
        confetti9.SetActive(true);
        confetti10.SetActive(true);
        confetti11.SetActive(true);
    }
}
