Tabii, işte projeniz için kapsamlı bir `README.md` içeriği:

```markdown
# False Hyper Casual Game

This is a Unity-based hyper-casual game project. The game includes various scripts to handle different game mechanics such as triggering confetti effects, rotating objects, and managing game areas.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Scripts](#scripts)
  - [AreaFalse](#areafalse)
  - [Spinner](#spinner)
  - [TriggerConfetti](#triggerconfetti)
  - [FalseHyperCasual](#falsehypercasual)
- [Contributing](#contributing)
- [License](#license)

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/SavasTanriverdi/FalseHyperCasualGame.git
    ```
2. Open the project in Unity.

## Usage

- Attach the `AreaFalse` script to a GameObject with a Collider set as a trigger to deactivate a specified area when the player enters.
- Attach the `Spinner` script to any GameObject to make it rotate based on specified angles and speed.
- Attach the `TriggerConfetti` script to a GameObject with a Collider set as a trigger to activate multiple confetti GameObjects when the player enters.
- Attach the `FalseHyperCasual` script to a GameObject to ensure all confetti GameObjects are deactivated at the start of the game.

## Scripts

### AreaFalse

This script deactivates a specified area when the player enters the trigger.

```csharp
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
```

### Spinner

This script rotates a GameObject based on specified angles and speed.

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

### TriggerConfetti

This script activates multiple confetti GameObjects when the player enters the trigger.

```csharp
using UnityEngine;

public class TriggerConfetti : MonoBehaviour
{
    [SerializeField] private GameObject confetti1;
    [SerializeField] private GameObject confetti2;
    [SerializeField] private GameObject confetti3;
    [SerializeField] private GameObject confetti4;
    [SerializeField] private GameObject confetti5;
    [SerializeField] private GameObject confetti6;
    [SerializeField] private GameObject confetti7;
    [SerializeField] private GameObject confetti8;
    [SerializeField] private GameObject confetti9;
    [SerializeField] private GameObject confetti10;
    [SerializeField] private GameObject confetti11;

    private void OnTriggerEnter(Collider other)
    {
        confetti1.SetActive(true);
        confetti2.SetActive(true);
        confetti3.SetActive(true);
        confetti4.SetActive(true);
        confetti5.SetActive(true);
        confetti6.SetActive(true);
        confetti7.SetActive(true);
        confetti8.SetActive(true);
        confetti9.SetActive(true);
        confetti10.SetActive(true);
        confetti11.SetActive(true);
    }
}
```

### FalseHyperCasual

This script ensures all confetti GameObjects are deactivated at the start of the game.

```csharp
using System;
using UnityEngine;

public class FalseHyperCasual : MonoBehaviour
{
    [SerializeField] private GameObject confetti1;
    [SerializeField] private GameObject confetti2;
    [SerializeField] private GameObject confetti3;
    [SerializeField] private GameObject confetti4;
    [SerializeField] private GameObject confetti5;
    [SerializeField] private GameObject confetti6;
    [SerializeField] private GameObject confetti7;
    [SerializeField] private GameObject confetti8;
    [SerializeField] private GameObject confetti9;
    [SerializeField] private GameObject confetti10;
    [SerializeField] private GameObject confetti11;

    private void Awake()
    {
        confetti1.SetActive(false);
        confetti2.SetActive(false);
        confetti3.SetActive(false);
        confetti4.SetActive(false);
        confetti5.SetActive(false);
        confetti6.SetActive(false);
        confetti7.SetActive(false);
        confetti8.SetActive(false);
        confetti9.SetActive(false);
        confetti10.SetActive(false);
        confetti11.SetActive(false);
    }
}
```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
```
