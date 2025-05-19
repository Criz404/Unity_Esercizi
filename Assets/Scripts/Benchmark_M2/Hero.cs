using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class Hero
{
    [SerializeField] private string name;
    [SerializeField] private int hp;
    [SerializeField] private Stats baseStats;
    [SerializeField] private ELEMENT resistance;
    [SerializeField] private ELEMENT weakness;
    [SerializeField] private Weapon weapon;

    public Hero(string name, int hp, Stats baseStats, ELEMENT resistance, ELEMENT weakness, Weapon weapon)
    {
        this.name = name;
        this.hp = hp;  
        this.baseStats = baseStats;
        this.resistance = resistance;
        this.weakness = weakness;
        this.weapon = weapon;
    }


    public int AddHp(int amount)
    {
        int hpCurrent;
        hpCurrent = GetHeroHp();
        hpCurrent += amount;
        SetHeroHp(hpCurrent);
        return hpCurrent;
    }

    public int TakeDamage(int damage)
    {
        int hpCurrent;
        hpCurrent = GetHeroHp();
        hpCurrent -= damage;
        SetHeroHp(hpCurrent);
        return hpCurrent;
    }

    public bool IsAlive() 
    {
        int hp;
        hp = GetHeroHp();
        return hp > 0;
    }

    public string GetHeroName()
    {
        return name;
    }

    public void SetHeroName(string name)
    {
        this.name = name;
    }

    public int GetHeroHp() 
    { 
        return hp; 
    }

    public void SetHeroHp(int hp)
    {
        if(hp > 0)
        {
            this.hp = hp;
        }
        else
        {
            this.hp = 0;
        }
    }

    public Stats GetHeroStats()
    {
        return baseStats;
    }

    public void SetHeroStats(Stats baseStats)
    {
        this.baseStats = baseStats;
    }

    public ELEMENT GetHeroResistance() 
    {
        return resistance;
    }

    public void SetHeroResistance(ELEMENT resistance)
    {
        this.resistance = resistance;
    }

    public ELEMENT GetHeroWeakness()
    {
        return weakness;
    }

    public void SetHeroWeakness(ELEMENT weakness)
    {
        this.weakness = weakness;
    }

    public Weapon GetHeroWeapon()
    {
        return weapon;
    }

    public void SetHeroWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }
}
