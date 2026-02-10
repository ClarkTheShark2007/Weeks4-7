using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            transform.position += transform.right * -1;
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            transform.position += transform.right;
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            transform.position += transform.up;
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            transform.position += transform.up * -1;
        }
    }
}
