using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;

    public UnityEvent<float> OnRandomNumber;


    void Start()
    {

    }

    void Update()
    {
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true)
            {

            }
            else
            {
                //Just Entering
                isInHazard = true;
                Debug.Log("Enter Hazard");
                OnEnterHazard.Invoke();
            }
        }
        else
        {
            if (isInHazard == true)
            {
                //Just Left
                isInHazard = false;
                Debug.Log("Exit Hazard");
                OnExitHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(1f, 99f));
            } else
            {

            }
        }
    }

    public void Rnado (float number) {
        Debug.Log(number);
    }
}
