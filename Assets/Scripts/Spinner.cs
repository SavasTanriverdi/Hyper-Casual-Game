using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    void Update()
    {
        transform.Rotate(xAngle * Time.deltaTime * speed, yAngle * Time.deltaTime * speed, zAngle * Time.deltaTime * speed);
    }
}
