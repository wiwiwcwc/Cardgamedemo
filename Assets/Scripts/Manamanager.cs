using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manamanager : MonoBehaviour {

    // Use this for initialization
    public int MaxMana;
    public int CurrentMana;
    
    
	void Start () {
        CurrentMana = MaxMana;
	}
	
	// Update is called once per frame
	void Update () {

        var manadisplay = this.transform.Find("ManaDisplay");
        manadisplay.GetComponent<Text>().text = "" + CurrentMana + "/" + MaxMana;
    }
}
