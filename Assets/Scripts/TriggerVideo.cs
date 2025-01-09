using UnityEngine;

public class TriggerVideo : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayer; // videoPlayer, videoyu temsil eder
    
    private void OnTriggerEnter(Collider other) // OnTriggerEnter, bir objenin trigger'ına başka bir obje girdiğinde çalışır
    {
        if (other.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
        }
    }
    
}
