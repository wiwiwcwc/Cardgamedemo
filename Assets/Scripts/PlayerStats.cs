using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int Maxhealth;
    public int Currenthealth;

    public void Takedamage(int damage){
        if (damage >= 0)
        {
            Currenthealth -= damage;
        }
    }

    // Use this for initialization
    void Start () {
        Currenthealth = Maxhealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
