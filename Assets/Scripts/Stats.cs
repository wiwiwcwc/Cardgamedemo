using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    public Card card;

    public int cost ;
    public new string name;
    public string carddescription;
    public int attackdamage = 0;
    public int armor = 0;
    public bool aoe = false;
<<<<<<< HEAD

=======
>>>>>>> b9b8df1192f18a6248e45c5e728de3b630c1d012


    public Text costText;
    public Text nameText;
    public Text carddescriptionText;


	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
         var costdisplay = this.transform.Find("Cost");
         costdisplay.GetComponent<Text>().text = "" + cost;
         var title = this.transform.Find("Title");
         title.GetComponent<Text>().text = name;
         var description = this.transform.Find("Description");
         description.GetComponent<Text>().text = carddescription;
         
    }
}
