using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    
    int hits = 0;
    
    private void OnCollisionEnter(Collision other) // OnCollisionEnter, bir çarpışma algılandığında çalışır
    {
        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }
    }
}
