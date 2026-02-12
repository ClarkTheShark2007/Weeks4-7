using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class SpellGhast : MonoBehaviour
{
    Vector2 bottomLeft;
    Vector2 topRight;
    float ghastSpeed;
    public int ghastHealth;
    public TextMeshProUGUI healthValue;
    SpriteRenderer sr;
    AudioSource ghastHurt;
    public GameObject ghastGroup;
    public GameObject ghastHPBar;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ghastHurt = GetComponent<AudioSource>();

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        transform.position = new Vector2(topRight.x + 3, Random.Range(-3f, 3));

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
        healthValue.text = ghastHealth.ToString();

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
