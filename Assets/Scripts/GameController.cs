using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameController : MonoBehaviour
{

    public BowClass BC;





    private void Start()
    {
        if (BC.BCDTO != null) SetBow();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) GravarJson();
        if (Input.GetKeyDown(KeyCode.X)) LerJson();
    }


    public void SetBow()
    {
            BC.nameItem = BC.BCDTO.nameItem;
            BC.thisType = BC.BCDTO.thisType;
            BC.bowType = BC.BCDTO.bowType;
            BC.handling = BC.BCDTO.handling;
            BC.SlotModification = BC.BCDTO.SlotModification;
            BC.limitAmmo = BC.BCDTO.limitAmmo;

            BC.typeArrow = BC.BCDTO.typeArrow;

            if (BC.typeArrow != null)
            {
                foreach (var arrowType in BC.BCDTO.typeArrow)
                {
                    arrowType.nameItem = arrowType.ACDTO.nameItem;
                    arrowType.ammoType = arrowType.ACDTO.ammoType;
                    arrowType.damage = arrowType.ACDTO.damage;
                    arrowType.elementalSeverity = arrowType.ACDTO.elementalSeverity;
                    arrowType.elementalType = arrowType.ACDTO.elementalType;
                    arrowType.cost = arrowType.ACDTO.cost;
                    arrowType.tear = arrowType.ACDTO.tear;
                    arrowType.ammoQnt = arrowType.ACDTO.ammoQnt;
                }
            }
    }




    public void GravarJson()
    {

        string str = JsonUtility.ToJson(BC, true);
        Debug.Log(str);
        File.WriteAllText(Application.dataPath + "/Resources/Text/SaveGame.json", str);
    }


    public void LerJson()
    {
        string str1 = File.ReadAllText(Application.dataPath + "/Resources/Text/SaveGame.json");
        Debug.Log(str1);
        
        var saved = JsonUtility.FromJson<BowClass>(str1);
        //Debug.Log(saved.nameItem);       //No Console aparece sempre NULL

        BC = saved;
        //RodarJson(saved);
    }



}
