using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BowClass : ItemBase
{    
    public BowClassDTO BCDTO;

    public RangeType thisType;

    public AmmoType bowType;

    public int handling;

    public int SlotModification;
    
    public int limitAmmo; //Limite de munição

    [SerializeField]
    public ArrowClass[] typeArrow;

}
