using UnityEngine;

public class SpellSpawner : MonoBehaviour
{
    public GameObject FireSpell;
    public GameObject IceSpell;
    public GameObject ThunderstormSpell;

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
            Debug.Log("Ice Spell Casted");
            Instantiate(ThunderstormSpell);
        }
        else if(spellID == 4)
        {
            
        }
        else if(spellID == 5)
        {
            
        }
        else if(spellID == 6)
        {
            
        }
    }
}
