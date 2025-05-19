using System;
using System.Security.Cryptography;
using Unity.Burst.Intrinsics;
using UnityEngine;

[System.Serializable]
public class Weapon
{
    public enum DAMAGE_TYPE { PHYSICAL, MAGICAL };
    [SerializeField] private string name;
    [SerializeField] private DAMAGE_TYPE dmgType;
    [SerializeField] private ELEMENT elem;
    [SerializeField] private Stats bonusStats;

    public Weapon(string name, DAMAGE_TYPE dmgType, ELEMENT elem, Stats bonusStats)
    {
        this.name = name;
        this.dmgType = dmgType;
        this.elem = elem;
        this.bonusStats = bonusStats;
    }

    public string GetWeaponName()
    {
        return name;
    }

    public void SetWeaponName(string name)
    {
        this.name = name;
    }

    public DAMAGE_TYPE GetWeaponDamageType()
    {
        return dmgType;
    }

    public void SetWeaponDamageType(DAMAGE_TYPE damageType)
    {
        this.dmgType = damageType;
    }

    public ELEMENT GetWeaponElement()
    {
        return elem;
    }

    public void SetWeaponElement(ELEMENT elem)
    {
        this.elem = elem;
    }

    public Stats GetWeaponStats()
    {
        return bonusStats;
    }

    public void SetWeaponStats(Stats bonusStats)
    {
        this.bonusStats = bonusStats;
    }

}
