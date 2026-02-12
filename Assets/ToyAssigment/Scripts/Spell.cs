using UnityEngine;

public class Spell : MonoBehaviour
{
    Vector2 bottomLeft;
    Vector2 topRight;
    public bool BottomStart;
    public bool TopStart;
    public float speed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        if(TopStart)
        {
            transform.position = new Vector2(0, topRight.y) + Random.insideUnitCircle * 8;
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
    }
}
