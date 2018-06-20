using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public int turncount = 1;
    public int turnofplayer = 0;
    public GameSetup a;

    private void Awake()
    {
        a = GameObject.Find("Canvas").GetComponent<GameSetup>();
    }

    public void EndTurn()
    {
        //引用各种变量

        var enemy = GameObject.Find("Enemy").GetComponent<EnemyStats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        var player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        var handmanager = GameObject.Find("Hand").GetComponent<HandManager>();



        //a.player[turnofplayer].SetActive(true);
       // a.player[turnofplayer+1].SetActive(false);
        //处理回合结束时执行动作


        handmanager.Discardall(); //弃牌
        enemy.Takeaction();       //敌方行动
       // a.player[turnofplayer].SetActive(false);
       // turnofplayer++;
        BeginTurn();              //开始回合
    }



    public void BeginTurn()
    {
       // a.player[turnofplayer].SetActive(true);
        var enemy = GameObject.Find("Enemy").GetComponent<EnemyStats>();
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        var player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();

        player.armor = 0;
        turncount++;
        
        mana.CurrentMana = mana.MaxMana;
        GameObject.Find("Deck").GetComponent<Decklist>().Draw(5);

        turnofplayer = 0;
        
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
