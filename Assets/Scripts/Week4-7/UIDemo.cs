using UnityEngine;
using UnityEngine.InputSystem;

public class UIDemo : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame == true) { 
        
            changeColour();
        }
    }

    public void changeColour()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    public void SetScale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
