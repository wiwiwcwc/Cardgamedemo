using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// 这个是处理玩家卡片的效果
public class Effect : MonoBehaviour {

    GameObject target;

    public void Dealdamage(int damage)      // 玩家对怪物造成伤害， 以后要改一下对象
    {
        var stats = this.gameObject.GetComponent<Stats>();
        if (stats.aoe == false)
        {


            target = GameObject.Find("Enemy");

            if (damage >= 0)
            {
                target.GetComponent<EnemyStats>().Currenthealth -= damage;
            }
        }
        else
        {
           var targets = GameObject.FindGameObjectsWithTag("Enemy");
           Debug.Log(targets);
            

        }
    }

    public void Increasearmor(int armor)
    {
        target = GameObject.Find("Player");

        if (armor >= 0)
        {
            target.GetComponent<PlayerStats>().armor += armor;
        }

    }


    public void Triggereffect()        // 点击后的效果
    {
        var stats = this.transform.GetComponent<Stats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();

        if (stats.cost <= mana.CurrentMana)
        {
            //Debug.Log("" + this.gameObject.name + "effects has triggered");
            Dealdamage(stats.attackdamage);
            Increasearmor(stats.armor);
            mana.CurrentMana -= stats.cost;
        }
        //触发完就送入坟场
        var graveyard = GameObject.Find("Graveyard").GetComponent<Graveyardlist>();
        
        graveyard.graveyardlist.Add(Instantiate(this.gameObject));
        Destroy(this.gameObject);

    }




	// Use this for initialization
	void Start () {
       // Debug.Log("deal 1 damage");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
