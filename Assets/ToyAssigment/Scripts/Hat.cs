using System.Security.Cryptography;
using UnityEngine;

public class Hat : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetScale(float scale)
    {
        if(scale == 0)
        {
            spriteRenderer.color = Color.white;
        } else if (scale == 1)
        {
            spriteRenderer.color = Color.red;
        } else if (scale == 2)
        {
            spriteRenderer.color = Color.yellow;
        } else if (scale == 3)
        {
            spriteRenderer.color = Color.black;
        } 
    }
}
