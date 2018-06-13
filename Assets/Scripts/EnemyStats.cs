using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

    public int Maxhealth;
    public int Currenthealth;
    public List<int> damage = new List<int>(new int[]{2,4,6} );




	// Use this for initialization
	void Start () {

        Currenthealth = Maxhealth;
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
