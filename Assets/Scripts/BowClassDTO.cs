using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RangeType { RangedWeapon, StealthWeapon, MelleWeapon }

[CreateAssetMenu(fileName = "ItensSerialized", menuName = "Itens/New Bow")]
public class BowClassDTO : ItemBaseDTO
{
    
    public RangeType thisType;

    public AmmoType bowType;

    public int handling;

    public int SlotModification;

    public int limitAmmo; //Limite de munição
    

    [SerializeField]
    public ArrowClass[] typeArrow;
}
