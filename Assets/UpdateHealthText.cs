using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.transform.GetComponent<Text>().text = "29/35";

    }

    // Update is called once per frame
    void Update () {
        //this.transform.parent.GetComponent<Text>().text="29/35";

    }
}
