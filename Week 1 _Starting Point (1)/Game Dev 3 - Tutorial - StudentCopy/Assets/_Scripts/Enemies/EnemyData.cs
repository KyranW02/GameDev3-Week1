using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "ScriptableObjects/EnemyData")]

public class EnemyData : ScriptableObject
{
    public Sprite shipSprite;
    public float shipSpeed;
    public int shipHP;
}
