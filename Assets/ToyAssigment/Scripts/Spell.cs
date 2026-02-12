using UnityEngine;

public class Spell : MonoBehaviour
{
    Vector2 bottomLeft;
    Vector2 topRight;
    public bool BottomStart;
    public bool TopStart;
    public bool canRotate;
    public float speed;
    float randomRotateDirection;
    public bool dontSpawnRandomly;
    public bool canBounce;
    float bounceTimer;
    float directionBounce = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        randomRotateDirection = Random.Range(-1f, 1f);

        if(randomRotateDirection >= 0.01f)
        {
            randomRotateDirection = 1f;
        } else
        {
            randomRotateDirection = -1f;
        }

        if(!dontSpawnRandomly)
        {
            bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        }

        if(TopStart)
        {
            transform.position = new Vector2(0 + Random.Range(-7f, 7f), topRight.y + Random.Range(2f, 4f));
            speed = speed * -1;
        }

        if(BottomStart)
        {
            transform.position = new Vector2(0, bottomLeft.y) + Random.insideUnitCircle * 8;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, Time.deltaTime * speed, 0);
        if(canRotate)
        {
            Vector3 spellRotation = transform.eulerAngles;
            spellRotation.z += speed *15 * randomRotateDirection * Time.deltaTime;
            transform.eulerAngles = spellRotation;
        }

        if(canBounce)
        {
            bounceTimer += Time.deltaTime;

            if(bounceTimer >= 1f)
            {
                speed = speed * -1;
                bounceTimer = 0;
            }

        }
    }
}
