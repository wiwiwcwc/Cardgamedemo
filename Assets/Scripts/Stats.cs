using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour {

    public int cost;
    public string name;
    public string description;

	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        var costdisplay = this.transform.Find("Cost");
        costdisplay.GetComponent<Text>().text = "" + cost;
        var title = this.transform.Find("Title");
        title.GetComponent<Text>().text = name;
	}
}
