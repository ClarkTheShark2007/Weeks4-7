using UnityEngine;
using System.Collections.Generic;

public class Backgrounds : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public List<Sprite> Images; //Public refernce to other Sprites
    int currentBackground = 0; //Background Index

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void sliderChange(float scale) //Changes the current background from a public refernced list, depening on the current slider value (Ranges from 0 to 3)
    {
        currentBackground = (int) scale;
        spriteRenderer.sprite = Images[currentBackground];

    }
}
