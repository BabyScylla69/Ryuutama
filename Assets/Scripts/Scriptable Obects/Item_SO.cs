using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{   
    Sellable, 
    Equipment,
    Food
};

public class Item_SO : ScriptableObject
{
    public ItemType type;
    public string itemName;
    public int price;
}
