using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public float trapTimer;
    public float trapTimerMax;
    public GameObject trap;

    // Update is called once per frame

    private void Start()
    {
        trapTimer = trapTimerMax;
    }
    void Update()
    {
        trapTimer -= Time.deltaTime;

        if(trapTimer <= 0)
        {
            setActiveTrap();
            trapTimer = trapTimerMax;

        }
    }

    void setActiveTrap()
    {
        if (trap.activeInHierarchy == true)
        {
            trap.SetActive(false);
        }
        else
        {
            trap.SetActive(true);
        }
    }
}
