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
        //Creates a win effect if 5 spells are currently casted
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
        //When called, a takes in an Int, int determines what prefab is instanitate
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
