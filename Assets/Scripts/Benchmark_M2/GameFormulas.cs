using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using static Weapon;

public static class GameFormulas
{
   
    public static bool HasElementAdvantage(ELEMENT attackElement, Hero defender)
    {
        return attackElement == defender.GetHeroWeakness();
    }

    public static bool HasElementDisadvantage(ELEMENT attackElement, Hero defender)
    {
        return attackElement == defender.GetHeroResistance();
    }

    public static float EvaluateElementalModifier(ELEMENT attackElement, Hero defender)
    {
        if (HasElementAdvantage(attackElement, defender))
            return 1.5f;
        if (HasElementDisadvantage(attackElement, defender))
            return 0.5f;
        return 1f;
    }

    public static bool HasHit(Stats attacker, Stats defender)
    {
        int hitChance = attacker.aim - defender.eva;
        int roll = Random.Range(0, 100);

        if (roll > hitChance)
        {
            Debug.Log("MISS");
            return false;
        }

        return true;
    }

    public static bool IsCrit(int critValue)
    {
        int roll = Random.Range(0, 100);

        if (roll < critValue)
        {
            Debug.Log("CRIT");
            return true;
        }

        return false;
    }

    public static int CalculateDamage(Hero attacker, Hero defender)
    {
        Stats attackerStats = Stats.Sum(attacker.GetHeroStats(), attacker.GetHeroWeapon().GetWeaponStats());

        Stats defenderStats = Stats.Sum(defender.GetHeroStats(), defender.GetHeroWeapon().GetWeaponStats());

        int defense = (attacker.GetHeroWeapon().GetWeaponDamageType() == DAMAGE_TYPE.PHYSICAL) ? defenderStats.def : defenderStats.res;

        int damage = attacker.GetHeroStats().atk - defense;

        // Modificatore elementale
        float modifier = EvaluateElementalModifier(attacker.GetHeroWeapon().GetWeaponElement(), defender);
        float modifiedDamage = damage * modifier;

        // Critico
        if (IsCrit(attackerStats.crt))
        {
            modifiedDamage *= 2f;
        }

        return Mathf.Max(0, Mathf.RoundToInt(modifiedDamage));
    }
}
