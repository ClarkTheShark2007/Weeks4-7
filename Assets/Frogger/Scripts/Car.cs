using UnityEngine;

public class Car : MonoBehaviour
{
    float speed = 3f;

    Vector2 bottomLeft;
    Vector2 topRight;

    Vector2 RespawnPos;
    void Start()
    {

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        transform.position = new Vector2(topRight.x + 2, 2) + Random.insideUnitCircle * 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x -= speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x < -4) //Left Edge 
        {
            newPos = new Vector2(topRight.x + 2, 2) + Random.insideUnitCircle * 2;
        }

        transform.position = newPos;
    }
}
