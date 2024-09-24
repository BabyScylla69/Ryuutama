using System;
using UnityEngine;

[Flags]
public enum Season
{
    Summer  = 1 << 0,
    Fall    = 1 << 1,
    Winter  = 1 << 2,
    Spring  = 1 << 3
};
[Flags]
public enum Habitat
{ 
    Wasteland = 1, 
    Rocky_terrain = 2, 
    Woods = 4,
    Grassland = 8, 
    Desert = 16
};

[CreateAssetMenu(menuName = "My Assets/Foe")]
public class Foe_SO : ScriptableObject
{
    public string monsterName;
    public int level;
    [Header("Monster Info")]
    public Habitat habitat;
    public Season season;
    public ScriptableObject[] materials;
    [Header("Stats")]
    public int dragonicaNumber;
    public int hp;
    public int mp;
    public int initiative;
    public int condition;
    [Header("Combat Info")]
    public int[] abilities;
    public int[] accuracy;
    public int damage, armor;
    [Header("Miscelanious")]
    [TextArea(3, 20)] public string description;
    public string specialAbility;
    [TextArea(2, 20)] public string sA_Description;
}
