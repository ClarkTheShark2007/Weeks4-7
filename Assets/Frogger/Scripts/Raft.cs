using UnityEngine;

public class Raft : MonoBehaviour
{
    float speed = 3f;

    Vector2 bottomLeft;

    void Start()
    {

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));

        transform.position = new Vector2(bottomLeft.x -2, -2) + Random.insideUnitCircle * 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        if (screenPos.x > Screen.width+4) //Left Edge 
        {
            newPos = new Vector2(bottomLeft.x - 2, -2) + Random.insideUnitCircle * 1;
        }

        transform.position = newPos;
    }
}
