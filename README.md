```markdown
# Obstacle Dodge

This is a Unity game project developed using C#. The project includes several scripts to control different game behaviors.

## Scripts

### FalseVideo.cs
This script controls the activation of a video player object.

```csharp
using System;
using UnityEngine;

public class FalseVideo : MonoBehaviour
{
    [SerializeField] private GameObject videoPlayer;

    private void Awake()
    {
        videoPlayer.SetActive(false);
    }
}
```

### FlyAtPlayer.cs
This script makes an object fly towards the player and destroys it when it reaches the player.

```csharp
using System;
using Unity.VisualScripting;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 0f;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        playerPosition = player.position;
    }

    private void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }

    private void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
```

### Spinner.cs
This script rotates an object based on specified angles and speed.

```csharp
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
```

### Mover.cs
This script allows the player to move using the WASD or arrow keys and prints instructions at the start.

```csharp
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        PrintInstructions();
    }

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

        transform.Translate(xValue, yValue, zValue);
    }
}
```

## How to Use
1. Clone the repository.
2. Open the project in Unity.
3. Attach the scripts to the appropriate GameObjects in your scene.
4. Configure the serialized fields in the Unity Editor as needed.
5. Play the game and enjoy!

## Requirements
- Unity 2020.3 or later
- .NET Framework 4.7.1 or later

## License
This project is licensed under the MIT License.
```

This `README.md` provides an overview of the project, descriptions of the scripts, and instructions on how to use the project.
