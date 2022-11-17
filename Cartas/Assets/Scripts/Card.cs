using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Nova carta", menuName = "Cartas")]
public class Card : ScriptableObject
{

    public string CardName;
    public int Cost;
    public int Power;
    public int Life;
    public Color Cor;

    
}
