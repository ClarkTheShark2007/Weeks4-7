using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float despawnTimer; //Chosen in inspector, diffrent for each spell
    float aliveTime;

    void Update() //Destroys prefabs (Spells), after a certain amount of time has past
    {
        aliveTime += Time.deltaTime;

        if(aliveTime >= despawnTimer)
        {
            Destroy(gameObject);
        }
    }
}
