using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceArrow : MonoBehaviour
{
    public int shootDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetShootDamage(int shootDamage)
    {
        this.shootDamage = shootDamage;
    }

    public int GetShootDamage()
    {
        return this.shootDamage;
    }
}
