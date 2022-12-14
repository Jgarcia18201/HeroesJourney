using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public static CardManager instance;
    public List<Card> cards = new List<Card>();
    public Transform player1Hand, player2Hand;
    public CardController cardControllerPreFab;

    public void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        GenerateCards();
    }

    private void GenerateCards()
    {
        foreach(Card card in cards)
        {
            CardController newCard = Instantiate(cardControllerPreFab, player1Hand);
            newCard.transform.localPosition = Vector3.zero;
            newCard.Initialize(card);
        }
    }
}
