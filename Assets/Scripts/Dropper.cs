using UnityEngine;

public class Dropper : MonoBehaviour
{
    
    [SerializeField]float timeToWait = 3f;

    private MeshRenderer myMeshRenderer; // MeshRenderer, objenin görünürlüğünü kontrol eder
    Rigidbody myRigidbody; // Rigidbody, objenin fiziksel özelliklerini kontrol eder
    
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>(); // GetComponent, objenin bir bileşenini alır
        myMeshRenderer.enabled = false;
        
        myRigidbody = GetComponent<Rigidbody>(); // GetComponent, objenin bir bileşenini alır
        myRigidbody.useGravity = false;
    }
    
    void Update()
    {
        if (Time.time > timeToWait)
        {
            
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }

        if (Time.time < timeToWait)
        {
            Debug.Log(Time.time);
        }
    }
}
