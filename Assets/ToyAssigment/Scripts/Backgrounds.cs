using UnityEngine;
using System.Collections.Generic;

public class Backgrounds : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public List<Sprite> Images;
    int currentBackground = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void sliderChange(float scale)
    {
        currentBackground = (int) scale;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
}
