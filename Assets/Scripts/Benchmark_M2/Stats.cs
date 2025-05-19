using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public struct Stats
{
    public int atk;
    public int def;
    public int res;
    public int spd;
    public int crt;
    public int aim;
    public int eva;

    public Stats(int atk, int def, int res, int spd, int crt, int aim, int eva)
    {
        this.atk = atk;
        this.def = def;
        this.res = res;
        this.spd = spd;
        this.crt = crt;
        this.aim = aim;
        this.eva = eva;
    }

    public static Stats Sum(Stats baseStats, Stats bonusStats)
    {
        Stats result = new Stats
        {
            atk = baseStats.atk + bonusStats.atk,
            def = baseStats.def + bonusStats.def,
            res = baseStats.res + bonusStats.res,
            spd = baseStats.spd + bonusStats.spd,
            crt = baseStats.crt + bonusStats.crt,
            aim = baseStats.aim + bonusStats.aim,
            eva = baseStats.eva + bonusStats.eva
        };
        return result;
    }
  
}
