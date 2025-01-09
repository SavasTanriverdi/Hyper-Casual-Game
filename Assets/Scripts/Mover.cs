using UnityEngine;

public class Mover : MonoBehaviour
{
    
    void Start()
    {
        PrintInstructions();
    }

    [SerializeField] float moveSpeed = 10f; // SerializeField, Unity Editor'da değeri değiştirmemizi sağlar
    
    void Update()
    {
        MovePlayer();
    }
    
    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue,yValue,zValue);


    }
}
