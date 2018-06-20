using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour {

	// Use this for initializatioz
    
    public  int playercount;
    public  int enemycount;
    public  GameObject[] player;
    public  GameObject[] enemy;


    private void Awake()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        playercount = player.Length;
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        enemycount = enemy.Length;
    }

    void Start () {


        Decklist decklist0 = player[0].GetComponentInChildren<Decklist>();
        HandManager handmanager0 = player[0].GetComponentInChildren<HandManager>();
        Stats stats0 = player[0].GetComponentInChildren<Stats>();

        decklist0.Addcard("ShieldUp");
        decklist0.Addcard("ShieldUp");
        decklist0.Addcard("ShieldUp");
        decklist0.Addcard("ShieldUp");
        decklist0.Addcard("Execute");
        decklist0.Addcard("Execute");

       
       // decklist0.Draw(stats0.carddraw);

        player[0].SetActive(false);



    }



    // Update is called once per frame
    void Update () {
		
	}
}
