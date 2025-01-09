using System;
using UnityEngine;

public class AreaFalse : MonoBehaviour
{
    [SerializeField] private GameObject area;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            area.SetActive(false);
        }
    }
}
