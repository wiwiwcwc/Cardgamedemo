using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

    GameObject target;

    public void dealdamage(int damage)
    {
        target = GameObject.Find("Enemy");

        if (damage >= 0)
        {
            target.GetComponent<Health>().Currenthealth -= damage;
        }


    }


    public void triggereffect()
    {
        var stats = this.transform.GetComponent<Stats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();

        if (stats.cost <= mana.CurrentMana)
        {
            Debug.Log("" + this.gameObject.name + "effects has triggered");
            dealdamage(stats.attackdamage);
            mana.CurrentMana -= stats.cost;
        }
    }




	// Use this for initialization
	void Start () {
       // Debug.Log("deal 1 damage");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
