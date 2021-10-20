using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class TarotSystem : MonoBehaviour
{
    public TarotCard[] tarotCards;
    // Card List
    // 0 = Card Back
    // 1 = The Fool
    // 2 = The Magician
    // 3 = The High Priestess
    // 4 = The Empress
    // 5 = The Emperor
    // 6 = The Hierophant
    // 7 = The Lovers
    // 8 = The Chariot
    // 9 = Strength
    // 10 = The Hermit
    // 11 = Wheel of Fortune
    // 12 = Justice
    // 13 = The Hanged Man
    // 14 = Death
    // 15 = Temperance
    // 16 = The Devil
    // 17 = The Tower
    // 18 = The Star
    // 19 = The Moon
    // 20 = The Sun
    // 21 = Judgement
    // 22 = The World

    public TarotCard firstCard = null;
    public TarotCard secondCard = null;
    public TarotCard thirdCard = null;

    public int firstCardUses = 0;
    public int secondCardUses = 0;
    public int thirdCardUses = 0;

    void Start()
    {
        //DialogueLua.SetVariable("Card", 1);
        //DialogueLua.GetVariable("Card");
    }

    void Update()
    {
        firstCard = tarotCards[DialogueLua.GetVariable("FirstCard").asInt];
        secondCard = tarotCards[DialogueLua.GetVariable("SecondCard").asInt];
        thirdCard = tarotCards[DialogueLua.GetVariable("ThirdCard").asInt];

        firstCardUses = DialogueLua.GetVariable("FirstCardUses").asInt;
        secondCardUses = DialogueLua.GetVariable("SecondCardUses").asInt;
        thirdCardUses = DialogueLua.GetVariable("ThirdCardUses").asInt;
    }

    public TarotCard EndOfChapterTally()
    {
        if (firstCardUses > secondCardUses && firstCardUses > thirdCardUses)
            return firstCard;
        else if (secondCardUses > firstCardUses && secondCardUses > thirdCardUses)
            return secondCard;
        else if (thirdCardUses > secondCardUses && thirdCardUses > firstCardUses)
            return thirdCard;
        else
        {
            TarotCard[] tempArray = new TarotCard[3] { firstCard, secondCard, thirdCard };
            return tempArray[Random.Range(0, tempArray.Length)];
        }       
    }

    public void ResetCardUses()
    {
        DialogueLua.SetVariable("FirstCardUses", 0);
        DialogueLua.SetVariable("SecondCardUses", 0);
        DialogueLua.SetVariable("ThirdCardUses", 0);
    }
}
