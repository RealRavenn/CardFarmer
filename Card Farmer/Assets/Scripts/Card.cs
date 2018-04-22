using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

    public string cardName;
    public string description;
    public Sprite artwork;
    public int cost;
    public int cost2;
    public int benefit;
    public int benefit2;

}
