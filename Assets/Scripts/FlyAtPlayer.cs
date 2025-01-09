using System;
using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    // SerializeField, Unity Editor'da değeri değiştirmemizi sağlar. Transform, objenin pozisyonunu, rotasyonunu ve ölçeğini temsil eder
    [SerializeField] Transform player; 
    
    
    Vector3 playerPosition; // Vector3, 3 boyutlu bir vektörü temsil eder
    
    
    [SerializeField] float speed = 0f;


    private void Awake() // Awake, obje oluşturulduğunda çalışır
    {
        gameObject.SetActive(false); // SetActive, objenin etkin olup olmadığını kontrol eder ve değiştirir
    }

    private void Start()
    {
        playerPosition = player.position; // position, objenin pozisyonunu temsil eder
    }

    

    private void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
        
    }

    private void MoveToPlayer() // MoveToPlayer, objenin oyuncuya doğru hareket etmesini sağlar
    {
        // Time.deltaTime, bir frame'in ne kadar sürdüğünü temsil eder
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        // transform.position, objenin pozisyonunu temsil eder
        // Vector3.MoveTowards, objenin bir pozisyondan diğerine doğru hareket etmesini sağlar
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition) // Eğer objenin pozisyonu oyuncunun pozisyonuna eşitse
        {
            Destroy(gameObject); // Destroy, objeyi yok eder. İkinci parametre
        }
        
    }
}
