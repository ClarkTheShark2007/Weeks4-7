using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject Player;
    new Vector2 topRight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        float playerY = Player.transform.position.y;
        if (playerY >= topRight.y - 2f)
        {
            Debug.Log("You win");
        }
    }
}
