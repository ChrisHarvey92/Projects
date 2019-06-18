using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spellDmg : MonoBehaviour
{
    public int playerLvl = 1;
    public int mAtk = 5;
    public int fireboltbaseDmg = 10;
    public int fireboltTotalDmg;
    public int voidburstbaseDmg = 5;
    public int voidburstTotalDmg;
    public int earthblastbaseDmg = 8;
    public int earthblastTotalDmg;
    public int arcanewallbaseDmg = 3;
    public int arcanewallTotalDmg;
    public int frostspraybaseDmg = 5;
    public int frostsprayTotalDmg;
    public int unstablechargebaseDmg = 20;
    public int unstablechargetotalDmg;

    private enemyHealth enemyhealth;
    private GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        fireboltTotalDmg = mAtk * fireboltbaseDmg;
        voidburstTotalDmg = mAtk * voidburstbaseDmg;
        earthblastTotalDmg = mAtk * earthblastbaseDmg;
        arcanewallTotalDmg = mAtk * arcanewallbaseDmg;
        frostsprayTotalDmg = mAtk * frostspraybaseDmg;
        unstablechargetotalDmg = mAtk * unstablechargebaseDmg;




    }
}
