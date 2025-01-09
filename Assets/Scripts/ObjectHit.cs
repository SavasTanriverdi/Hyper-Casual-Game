using System;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) // OnCollisionEnter, bir çarpışma algılandığında çalışır
    {
        if (other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit"; // gameObject, bu scriptin bağlı olduğu objeyi temsil eder ve tag'ini değiştirir
        }
        
    }
    
}
