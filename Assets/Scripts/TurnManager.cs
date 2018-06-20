using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public int turncount = 1;


    public void EndTurn()
    {
        //引用各种变量
        var enemy = GameObject.Find("Enemy").GetComponent<EnemyStats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        var player = GameObject.Find("Player").GetComponent<PlayerStats>();

        //处理回合结束时执行动作



        enemy.Takeaction();
        BeginTurn();
    }


    public void BeginTurn()
    {
        var enemy = GameObject.Find("Enemy").GetComponent<EnemyStats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        var player = GameObject.Find("Player").GetComponent<PlayerStats>();

        player.armor = 0;
        turncount++;
        
        mana.CurrentMana = mana.MaxMana;
        GameObject.Find("Deck").GetComponent<Decklist>().Draw();

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        if (mana.CurrentMana== 0)
        {
            EndTurn();
   
        }
    }
}
