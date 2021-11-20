using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementalType { None, Fire, Freeze, Shock, Corruption, ImpactDamage, Tear }
public enum AmmoType { HunterBow, WarBow, SharpshotBow }

[CreateAssetMenu(fileName = "ItensSerialized", menuName = "Itens/New Arrow")]

public class ArrowClassDTO : ItemBaseDTO
{
    public AmmoType ammoType;

    public int damage;  //Dano causado

    public int elementalSeverity; //Dano elemental causado

    public ElementalType elementalType;

    public int cost;

    public int tear;    //Quebrar escudo 

    public int ammoQnt; //quantidade de munição
}
