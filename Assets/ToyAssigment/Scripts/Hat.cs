using System.Security.Cryptography;
using UnityEngine;

public class Hat : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetColour(float Colour) //Slider determines a float, depending on current float change the colour of the wizard hat
    {
        if(Colour == 0)
        {
            spriteRenderer.color = Color.white;
        } else if (Colour == 1)
        {
            spriteRenderer.color = Color.red;
        } else if (Colour == 2)
        {
            spriteRenderer.color = Color.yellow;
        } else if (Colour == 3)
        {
            spriteRenderer.color = Color.black;
        } 
    }
}
