using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour {

    public int turncount = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var mana = GameObject.Find("Mana").GetComponent<Manamanager>();
        if (mana.CurrentMana== 0)
        {
            mana.CurrentMana = mana.MaxMana;
            turncount++;
        }
    }
}
