using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class SpellGhast : MonoBehaviour
{
    //Script used specifcally for the Ghast prefab object instead of requluar spell script
    Vector2 bottomLeft;
    Vector2 topRight;
    float ghastSpeed;
    public int ghastHealth;
    public TextMeshProUGUI healthValue;
    SpriteRenderer sr;
    AudioSource ghastHurt;
    public GameObject ghastGroup;
    public GameObject ghastHPBar;

    
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ghastHurt = GetComponent<AudioSource>();

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        //Spawns at the right of the screen with a random Y
        transform.position = new Vector2(topRight.x + 3, Random.Range(-3f, 3));

        //Ghast health and speed are randomizied (No set value via inspector)
        ghastSpeed = Random.Range(1f, 6f);
        ghastHealth = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        ghastEnemy();
        ghastMovement();
    }

    void ghastEnemy()
    {
        //Updates text with the current health value
        healthValue.text = ghastHealth.ToString();

        //Checks if the mouse is in the sprite bounds and if the player clicks if so, bring the ghast health down by 1 and play an audio
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        if (Mouse.current.leftButton.wasPressedThisFrame && sr.bounds.Contains(mousePos) == true)
        {
            ghastHealth--;
            ghastHurt.Play();
        }

        if(ghastHealth == 0)
        {
            Destroy(ghastGroup);
        }
    }

    void ghastMovement()
    {
        //Simple movement, bounces from right to left. If at the edge, flips the scale of X to corresponding direction

        Vector2 newPos = transform.position;
        newPos.x -= ghastSpeed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if(screenPos.x < 0) //Left Edge 
        {
            newPos.x = bottomLeft.x;
            ghastSpeed = ghastSpeed * -1;
            transform.localScale = new Vector2(-1,1);
        } 
        
        if (screenPos.x > Screen.width) //Right Edge
        {
            newPos.x = topRight.x;
            ghastSpeed = ghastSpeed * -1;
            transform.localScale = new Vector2(1,1);
        }

        transform.position = newPos;
        ghastHPBar.transform.position = transform.position + new Vector3(0,-1,0);

    }
}
