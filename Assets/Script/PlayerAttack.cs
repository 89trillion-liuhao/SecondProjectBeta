using System.Collections;
using System.Collections.Generic;
using Model;
using TableConfig;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject target;//动画目标 
    public int shootDamage;//攻击力
    private float timer;//攻击间隔事件
    private float minTimer= 1.5f;//最小攻击时间间隔
    private GameObject nowGameObject;
    private float x;
   
   
    void Start()
    {
        TableManager<ArmyModel> model = new TableManager<ArmyModel>();
        
        minTimer = 1 / model.GetModel(16001).ShootSpeed;
        timer = minTimer;
        shootDamage = model.GetModel(16001).Atk;


    }

    // Update is called once per frame
    
    void Update()
    {

        //if ( timer > minTimer)
        if (Input.GetKey(KeyCode.A) && timer > minTimer)
        {
            
            animator.SetBool("isAttack",true);
            // animator.SetBool("isStop",false);
            // animator.SetBool("isRun",false);
            //CreateAttack();
            timer = 0.0f;
        }
        else
        {
            timer += Time.deltaTime;
           
            animator.SetBool("isAttack",false);
            /*animator.SetBool("isStop",true);*/
        }
        if (x >= 7)
        {
            x = 0;
            //animator.SetBool("isAttack",false);
            Destroy(nowGameObject);
            return;

        }
        else if( nowGameObject != null)
        {
            nowGameObject.transform.position = new Vector3(5, 0.5f, x);
            //target.transform.rotation = Quaternion.Euler(new Vector3(x, 0.5f, x));
            x += 0.1f;
            
        }
        
        
        
        // Debug.Log(target.transform.position.x);
       

    }

    void CreateAttack()
    {
        //target.GetComponent<IceArrow>().SetShootDamage(shootDamage);
        target.GetComponent<IceArrow>().shootDamage = shootDamage;
        nowGameObject = Instantiate(target);
       
        //target.transform.SetParent();

    }

    void ShowRun()
    {
        animator.SetBool("isAttack",false);
        CreateAttack();
        /*animator.SetBool("isStop",false);
        animator.SetBool("isRun",false);
        animator.SetBool("isAttack",true);
        Debug.Log("回调");
        //animator = GameObject.Find("FrostArcher").GetComponent<Animator>();
        //animator.SetBool("");*/
    }
    
    
}
