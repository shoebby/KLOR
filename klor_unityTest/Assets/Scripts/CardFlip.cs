using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class CardFlip : MonoBehaviour
{
    public Sprite cardBack;
    public Sprite cardFace;

    public string thisName;

    private Image imgRenderer;
    private Animator animator;

    private TarotSystem tarotSystem;

    void Start()
    {
        imgRenderer = GetComponent<Image>();
        animator = GetComponent<Animator>();
        tarotSystem = FindObjectOfType<TarotSystem>();
        thisName = gameObject.name;

        if (thisName.Contains("1."))
            cardFace = tarotSystem.firstCard.cardFront;
        else if (thisName.Contains("2."))
            cardFace = tarotSystem.secondCard.cardFront;
        else if (thisName.Contains("3."))
            cardFace = tarotSystem.thirdCard.cardFront;
    }

    void Update()
    {
        if (thisName.Contains("1."))
            cardFace = tarotSystem.firstCard.cardFront;
        else if (thisName.Contains("2."))
            cardFace = tarotSystem.secondCard.cardFront;
        else if (thisName.Contains("3."))
            cardFace = tarotSystem.thirdCard.cardFront;

        if (isPlaying(animator, "Highlighted"))
            SetCard(cardFace);
        else
            SetCard(cardBack);
    }

    public void SetCard(Sprite cardSprite)
    {
        imgRenderer.sprite = cardSprite;
    }

    bool isPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName))
            return true;
        else
            return false;
    }
}
