using System;
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

    public void  Draw(int n){
        // 从卡组抽一张牌加入到手牌
        for (; n > 0;n--)
        {


            if (deck.Count() > 0)
            {
                var hand = GameObject.Find("Hand").GetComponent<HandManager>().hand; //reference手牌
                GameObject cardtoberemoved = deck[0];   //即将抽取的牌
                GameObject card = Instantiate(deck[0]);
                card.transform.SetParent(GameObject.Find("Hand").transform);
                hand.Add(card);
                deck.Remove(cardtoberemoved);
                Destroy(cardtoberemoved);
            }
            else
            {
                Shuffle();   //如果卡组没牌就洗牌并抽一张

            }
        }
    }

    public void Shuffle() {
        var gyl = GameObject.Find("Graveyard").GetComponent<Graveyardlist>().graveyardlist;  //指向到墓地的卡婊
        if (gyl.Count() > 0)    // 墓地没卡就不抽了
        {


            deck.AddRange(gyl);
            Shuffledeck();
            gyl.Clear();
            Draw(1);
        }
    }

    //洗卡组
    public void Shuffledeck()
    {
        deck = deck.OrderBy(a => Guid.NewGuid()).ToList();

    }


    // Use this for initialization
    void Start () {
        Addcard("ShieldUp");
        Addcard("Whirlwind");
        Addcard("Execute");
        Addcard("MortalStrike");
        Addcard("HeroicStrike");
        Addcard("HeroicStrike");
        Addcard("HeroicStrike");
        Addcard("MortalStrike");
        Addcard("ShieldUp");
        Shuffledeck();
        Draw(5);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
