using UnityEngine;

public class Spell : MonoBehaviour
{
    //Script used for all Spell prefabs, customizable in the inspector
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

    void Start()
    {
        //Used to deterinined if the object can rotate will it go clock or counter, by using a random number between -1 to 1, then choosing in between 0
        randomRotateDirection = Random.Range(-1f, 1f);

        if(randomRotateDirection >= 0.01f)
        {
            randomRotateDirection = 1f;
        } else
        {
            randomRotateDirection = -1f;
        }

        //If true, then object will not spawn randomly around the screen, and will keep theyre inital placed transform position
        if(!dontSpawnRandomly)
        {
            bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
            topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        }

        //If one is choosen, will redirect to a starting position of bottom or top
        if(TopStart)
        {
            transform.position = new Vector2(0 + Random.Range(-7f, 7f), topRight.y + Random.Range(2f, 4f));
            speed = speed * -1;
        }

        if(BottomStart)
        {
            transform.position = new Vector2(0 + Random.Range(-7f, 7f), bottomLeft.y + Random.Range(2f, 4f));
        }
    }

    void Update()
    {
        //Moves the object up and down, depending on speed value
        transform.position += new Vector3(0, Time.deltaTime * speed, 0);
        
        //Roate object dependent on what was randomRotateDirection
        if(canRotate)
        {
            Vector3 spellRotation = transform.eulerAngles;
            spellRotation.z += speed *15 * randomRotateDirection * Time.deltaTime;
            transform.eulerAngles = spellRotation;
        }

        //Creates a simple bounce animation by inverenting the speed value after a seccond
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
