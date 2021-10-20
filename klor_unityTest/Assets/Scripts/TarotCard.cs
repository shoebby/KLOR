using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tarot Card", menuName = "Tarot Cards")]
public class TarotCard : ScriptableObject
{
    public new string name;

    public string description;

    public Sprite cardFront;
}
