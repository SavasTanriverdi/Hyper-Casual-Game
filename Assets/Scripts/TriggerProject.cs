using System;
using UnityEngine;

public class TriggerProject : MonoBehaviour
{
    [SerializeField] private GameObject projectile; // projectile, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile1; // projectile1, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile2; // projectile2, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile3; // projectile3, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile4; // projectile4, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile5; // projectile5, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile6; // projectile6, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile7; // projectile7, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile8; // projectile8, atılacak objeyi temsil eder
    [SerializeField] private GameObject projectile9; // projectile9, atılacak objeyi temsil eder
    private void OnTriggerEnter(Collider other) // OnTriggerEnter, bir objenin trigger'ına başka bir obje girdiğinde çalışır
    {
        if (other.gameObject.tag == "Player")
        {
            projectile.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile1.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile2.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile3.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile4.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile5.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile6.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile7.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile8.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            projectile9.SetActive(true); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
            
            Destroy(gameObject); // Destroy, objeyi yok eder
        }
    }
}
