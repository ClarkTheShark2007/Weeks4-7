using UnityEngine;

public class Strategies : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float x = i;
            float y = i /10f;
            float z = 0;
            Instantiate(prefab, new Vector3 (x, y, z), Quaternion.identity);
        }
    }

}
