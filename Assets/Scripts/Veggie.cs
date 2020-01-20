using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Vegetable", menuName = "Vegetable")]
public class Veggie : ScriptableObject
{
    public string name;
    public float value;
    public Sprite[] image;
    public Sprite currentSprite;
    //Timer stuff
    public float timerSpeed;
    private float elapsed;
   


}
