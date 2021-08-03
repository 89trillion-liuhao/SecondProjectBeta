using System;
using System.Collections;
using System.Collections.Generic;
using Model;
using TableConfig;
using UnityEngine;
using UnityEngine.UI;

public class PlayHealth : MonoBehaviour
{
    // Start is called before the first frame update

    public int health;
    public GameObject healthPanel;
    public bool isAlive =true;
    void Start()
    {
        TableManager<ArmyModel> t = new TableManager<ArmyModel>();
        health = t.GetModel(16001).MaxHp;
        healthPanel.GetComponent<Text>().text =health.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("IceArrow"))
        {
           
            IceArrow iceArrow = other.gameObject.GetComponent<IceArrow>();
            TakeDamage(iceArrow.GetShootDamage());
            Destroy(other);
        }
    }

    // Update is called once per frame
    void Update()
    {
        healthPanel.GetComponent<Text>().text =health.ToString();
        if (health <= 0)
        {
            isAlive = false;  
            Destroy(this.gameObject);
        }
    }
    //
    public void TakeDamage(int damage)
    {
        //SetHealth();
        health -= damage;
        if (health < 0)
        {
            health = 0;
        }
    }
    // public void SetHealth(int Hp)
    // {
    //     health -= Hp;
    // }
}
