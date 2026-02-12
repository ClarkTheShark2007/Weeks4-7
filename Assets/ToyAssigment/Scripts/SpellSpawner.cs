using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
    public GameObject FireSpell;
    public GameObject IceSpell;
    public GameObject ThunderstormSpell;
    public GameObject EarthSpell;
    public GameObject GhastSpell;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CastSpell(int spellID)
    {
        if (spellID == 1)
        {
            Debug.Log("Fire Spell Casted");
            Instantiate(FireSpell);
        }
        else if (spellID == 2)
        {
            Debug.Log("Ice Spell Casted");
            Instantiate(IceSpell);
        }
        else if(spellID == 3)
        {
            Debug.Log("Thunder Spell Casted");
            Instantiate(ThunderstormSpell);
        }
        else if(spellID == 4)
        {
            Debug.Log("Earth Spell Casted");
            Instantiate(EarthSpell);
        }
        else if(spellID == 5)
        {
            Debug.Log("Ghast Spell Casted");
            Instantiate(GhastSpell);
        }
        else if(spellID == 6)
        {
            
        }
    }
}
