using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1ProjectTest : MonoBehaviour
{
    public Hero a; // Eroe A
    public Hero b; // Eroe B

    void Update()
    {
        // Se uno dei due eroi è morto, non fare nulla
        if (!a.IsAlive() || !b.IsAlive())
            return;

        // Eroe che attacca per primo
        Hero firstAttacker = a.GetHeroStats().spd >= b.GetHeroStats().spd ? a : b;
        Hero secondAttacker = a.GetHeroStats().spd >= b.GetHeroStats().spd ? b : a;

        // Stampa chi attacca e chi si difende
        Debug.Log($"{firstAttacker.GetHeroName()} attacca {secondAttacker.GetHeroName()}");

        // Attacco da parte del primo eroe
        Attack(firstAttacker, secondAttacker);

        // Se il secondo eroe è sopravvissuto, attacca anche lui
        if (secondAttacker.IsAlive())
        {
            // Stampa chi attacca e chi si difende
            Debug.Log($"{secondAttacker.GetHeroName()} attacca {firstAttacker.GetHeroName()}");

            // Attacco da parte del secondo eroe
            Attack(secondAttacker, firstAttacker);
        }
    }

    void Attack(Hero attacker, Hero defender)
    {
        // Verifica se il colpo va a segno
        bool hit = Random.Range(0, 100) < 75; // 75% di probabilità che l'attacco vada a segno (puoi cambiare la probabilità)

        if (hit)
        {
            // Se il colpo va a segno, verifica debolezze o resistenze
            if (defender.GetHeroWeakness() == attacker.GetHeroWeapon().GetWeaponElement())
            {
                Debug.Log("WEAKNESS");
            }
            else if (defender.GetHeroResistance() == attacker.GetHeroWeapon().GetWeaponElement())
            {
                Debug.Log("RESIST");
            }

            // Calcola il danno
            int damage = GameFormulas.CalculateDamage(a,b);

            // Stampa il danno
            Debug.Log($"{attacker.GetHeroName()} infligge {damage} danni a {defender.GetHeroName()}");

            // Infliggi il danno al difensore
            defender.TakeDamage(damage);

            // Verifica se il difensore è morto
            if (!defender.IsAlive())
            {
                Debug.Log($"{attacker.GetHeroName()} vince il duello!");
            }
        }
        else
        {
            Debug.Log($"{attacker.GetHeroName()} non è riuscito a colpire {defender.GetHeroName()}");
        }
    }
}
