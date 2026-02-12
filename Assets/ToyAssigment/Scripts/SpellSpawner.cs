using TMPro;
using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
    public GameObject FireSpell;
    public GameObject IceSpell;
    public GameObject ThunderstormSpell;
    public GameObject EarthSpell;
    public GameObject GhastSpell;
    public GameObject resetSpell;
    public GameObject winScreen;
    int totalSpellsCasted;
    public TextMeshProUGUI castText;


    // Update is called once per frame
    void Update()
    {
        castText.text = totalSpellsCasted.ToString();

        if(totalSpellsCasted >= 5)
        {
            winScreen.SetActive(true);
        } else
        {
            winScreen.SetActive(false);
        }
    }

    public void CastSpell(int spellID)
    {
        if (spellID == 1)
        {
            Debug.Log("Fire Spell Casted");
            Instantiate(FireSpell);
            totalSpellsCasted++;
        }
        else if (spellID == 2)
        {
            Debug.Log("Ice Spell Casted");
            Instantiate(IceSpell);
            totalSpellsCasted++;
        }
        else if(spellID == 3)
        {
            Debug.Log("Thunder Spell Casted");
            Instantiate(ThunderstormSpell);
            totalSpellsCasted++;
        }
        else if(spellID == 4)
        {
            Debug.Log("Earth Spell Casted");
            Instantiate(EarthSpell);
            totalSpellsCasted++;
        }
        else if(spellID == 5)
        {
            Debug.Log("Ghast Spell Casted");
            Instantiate(GhastSpell);
            totalSpellsCasted++;
        }
        else if(spellID == 6)
        {
            Instantiate(resetSpell);
            totalSpellsCasted = 0;
        }
    }
}
