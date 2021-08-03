using System.Collections;
using System.Collections.Generic;
using Model;
using TableConfig;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadCsv();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReadCsv()
    {
        TableManager<ArmyModel> o = new TableManager<ArmyModel>("csv/ArmyModel");
        
        List<ArmyModel> armyModels = o.GetAllModel();
        for (int i = 0;  i <armyModels.Count ; i++)
        {
            Debug.Log(armyModels[i].note);
            Debug.Log(armyModels[i].Name);
            Debug.Log(armyModels[i].MaxHp);
            Debug.Log(armyModels[i].Atk);
            Debug.Log(armyModels[i].Def);
            Debug.Log(armyModels[i].id);
        }
        


    }
}
