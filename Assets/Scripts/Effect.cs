using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

    GameObject target;

    public void Dealdamage(int damage)
    {
        target = GameObject.Find("Enemy");

        if (damage >= 0)
        {
            target.GetComponent<EnemyStats>().Currenthealth -= damage;
        }


    }


    public void triggereffect()
    {
        var stats = this.transform.GetComponent<Stats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();

        if (stats.cost <= mana.CurrentMana)
        {
            //Debug.Log("" + this.gameObject.name + "effects has triggered");
            Dealdamage(stats.attackdamage);
            mana.CurrentMana -= stats.cost;
        }
        //触发完就送入坟场
        // Destroy(this.transform.parent);
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
