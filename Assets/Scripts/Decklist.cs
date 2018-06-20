using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Decklist : MonoBehaviour {

    public int totalCards;
    public int remainingCards;
    public List<GameObject> deck= new List<GameObject>();


    public void Addcard(string name)
    {
        deck.Add(Instantiate(GameObject.Find(name) as GameObject));
    }

    public void  Draw(){
        // 从卡组抽一张牌加入到手牌
        if (deck.Count() > 0)
        {

            GameObject cardtoberemoved = deck[0];
            GameObject card = Instantiate(deck[0]);
            card.transform.SetParent(GameObject.Find("Hand").transform);
            deck.Remove(cardtoberemoved);
            Destroy(cardtoberemoved);    
        }
        else
        {
            Shuffle();   //如果卡组没牌就洗牌
             
        }
    }

    public void Shuffle() {
        var gyl = GameObject.Find("Graveyard").GetComponent<Graveyardlist>().graveyardlist;  //指向到墓地的卡婊
        if (gyl.Count() > 0)    // 墓地没卡就不洗了
        {


            deck.AddRange(gyl);
            gyl.Clear();
            Draw();
        }
    }


    // Use this for initialization
    void Start () {
        Addcard("ShieldUp");
        Addcard("Execute");
        Addcard("MortalStrike");
        Addcard("HeroicStrike");
        Addcard("HeroicStrike");
        Addcard("HeroicStrike");
        Addcard("MortalStrike");
        Addcard("ShieldUp");

        Draw();
        Draw();
        Draw();
        Draw();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
