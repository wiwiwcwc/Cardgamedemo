using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decklist : MonoBehaviour {

    public int totalCards;
    public int remainingCards;
    public List<GameObject> deck;

	// Use this for initialization
	void Start () {
        
        deck.Add(GameObject.Find("Card"));
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
