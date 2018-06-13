using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    public Card card;

    public int cost ;
    public new string name;
    public string carddescription;
    public int attackdamage;

    public Text costText;
    public Text nameText;
    public Text carddescriptionText;


	void Start () {

        attackdamage = card.attackdamage;
        costText.text = card.cost.ToString();
        nameText.text = card.name;
        carddescriptionText.text = card.carddescription;

    }
	
	// Update is called once per frame
	void Update () {
        /* var costdisplay = this.transform.Find("Cost");
         costdisplay.GetComponent<Text>().text = "" + cost;
         var title = this.transform.Find("Title");
         title.GetComponent<Text>().text = name;
         var description = this.transform.Find("Description");
         description.GetComponent<Text>().text = carddescription;
         */
        costText.text = card.cost.ToString();
        nameText.text = card.name;
        carddescriptionText.text = card.carddescription;




    }
}
