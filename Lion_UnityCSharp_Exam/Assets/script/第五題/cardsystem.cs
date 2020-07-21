using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
public class cardsystem : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    private string[] type={"Spades","Damond","Heart","Club"};
    private void Start()
    {
        GetAllCard();
    }

    private void GetAllCard()
    {
        for (int i = 0; i < type.Length; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                switch (j)
                {
                    
            
                }

                GameObject card= Resources.Load<GameObject>("PlayingCard_" + j + type[i]);
                cards.Add(card);
            }



        }
    
    }
}
