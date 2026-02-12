using UnityEngine;

public class Despawn : MonoBehaviour
{
    public float despawnTimer;
    float aliveTime;
    // Update is called once per frame
    void Update()
    {
        aliveTime += Time.deltaTime;

        if(aliveTime >= despawnTimer)
        {
            Destroy(gameObject);
        }
    }
}
