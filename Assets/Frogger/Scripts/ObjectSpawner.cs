using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject CarPrefab;
    GameObject spawnedCar;

    public List<GameObject> cars;

    public GameObject RaftPrefab;
    GameObject spawnedRaft;

    public List<GameObject> rafts;

    public Transform player;

    int carAmount;

    int raftAmount;

    float time;
    float timeR;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //for(int i = 0; i < 3; i++)
        //{
        //    spawnedCar = Instantiate(CarPrefab, transform);
        //    cars.Add(spawnedCar);
        //}
    }

    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;
        if(time >= 1f && carAmount <= 10)
        {
            spawnedCar = Instantiate(CarPrefab, transform);
            cars.Add(spawnedCar);
            carAmount++;
            time = 0;
        }

        timeR = timeR + Time.deltaTime;
        if (timeR >= 1f && raftAmount <= 10)
        {
            spawnedRaft = Instantiate(RaftPrefab, transform);
            rafts.Add(spawnedRaft);
            raftAmount++;
            timeR = 0;
        }

        for (int i = cars.Count - 1; i >= 0; i--)
        {
            float distance = Vector2.Distance(cars[i].transform.position, player.position);
            if (distance < 0.9f)
            {
                Debug.Log("Player Hit by car " + i);
                player.position = new Vector3(0, -4.32000017f, 0);

            }
        }

        for (int i = rafts.Count - 1; i >= 0; i--)
        {
            float rdistance = Vector2.Distance(rafts[i].transform.position, player.transform.position);
            if (rdistance <= 0.7f)
            {
                player.transform.position = rafts[i].transform.position;
                player.transform.parent = rafts[i].transform;
                Debug.Log("Player's Parent: " + player.transform.parent.name);
            }

            if (rdistance >= 1f)
            {
                player.transform.parent = null;
                //Debug.Log("Player's Parent: " + player.transform.parent.name);
            }
        }
    }
}
