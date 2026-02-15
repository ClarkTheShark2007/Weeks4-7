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
        //Simple timer, slider visuales what current value the time value is
        timerValue += Time.deltaTime;
        timerSlider.value = timerValue;
        if(timerValue > timerMaxValue)
        {
            timerValue = 10;
        }
    }

    public void SpellPressed()
    {
        //When pressed, if the timer is not at a max value, play the failed audio. Else reset timer and call spell spawn function with spell ID
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
