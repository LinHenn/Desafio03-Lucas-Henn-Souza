using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ArrowClass
{
    public string nameItem;

    public ArrowClassDTO ACDTO;

    public AmmoType ammoType;

    public int damage;  //Dano causado

    public int elementalSeverity; //Dano elemental causado

    public ElementalType elementalType;

    public int cost;

    public int tear;    //Quebrar escudo 

    public int ammoQnt; //quantidade de munição
}
