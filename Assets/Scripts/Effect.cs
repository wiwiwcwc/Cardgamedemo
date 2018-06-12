using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour {

    GameObject target;

    public void triggereffect()
    {
        Debug.Log("" + this.gameObject.name + "effects has triggered");
        target = GameObject.Find("Enemy");
        target.GetComponent<Health>().Currenthealth -= 5;
    }

	// Use this for initialization
	void Start () {
       // Debug.Log("deal 1 damage");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
