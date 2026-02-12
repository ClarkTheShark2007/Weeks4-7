using UnityEngine;
using UnityEngine.UI;

public class SpellTimer : MonoBehaviour
{
    float timerValue = 0;
    float timerMaxValue = 10;
    public Slider timerSlider;
    public SpellSpawner spellSpawner;
    public int spellID;
    AudioSource spellFailed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerSlider.maxValue = timerMaxValue;
        spellFailed = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += Time.deltaTime;
        timerSlider.value = timerValue;
        if(timerValue > timerMaxValue)
        {
            timerValue = 10;
        }
    }

    public void SpellPressed()
    {
        if(timerValue < timerMaxValue)
        {
            spellFailed.Play();
        } else
        {
            spellSpawner.CastSpell(spellID);
            timerValue = 0;
            timerSlider.value = timerValue;
        }
    }
}
