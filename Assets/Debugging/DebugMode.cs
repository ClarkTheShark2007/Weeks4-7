using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public GameObject shapePrefab;
    public int shapeCount;
    List<GameObject> shapes;
    
    void Start()
    {
        shapes = new List<GameObject>();
        for(int i = 0; i < shapeCount; i++)
        {
            GameObject shape  = Instantiate(shapePrefab, new Vector3(i * 2, 0, 0), Quaternion.identity);
            AddShapeToList(shape);
        }
    }

    void AddShapeToList(GameObject shape)
    {
        shapes.Add(shape);
    }
}
