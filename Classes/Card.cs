using BlazorProject.Models;
using BlazorProject.Interfaces;
using System.Collections.Generic;

namespace BlazorProject.Classes;

public class Card : ICard
{
    private List<CardModel> cards;

    public Card()
    {
        cards = new List<CardModel>()
        {
            new CardModel {Question = "Q1?", Answer = "A1?"},
            new CardModel {Question = "Q2?", Answer = "A2?"},
            new CardModel {Question = "Q3?", Answer = "A3?"}
        };
    }

    public List<CardModel> GetCards()
    {
        return cards;
    }

    public int GetCount()
    {
        return cards.Count();
    }

    public Type GetCardType()
    {
        return cards.GetType();
    }
}


