using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName = "New Item";
    public string itemDescription = "new Description";
    public int Damage;
    public int Armour;
    public enum Type {Default, Armour, Consumable, Weapon, Quest}
    public Type type = Type.Default;
    public Sprite icon;
}
