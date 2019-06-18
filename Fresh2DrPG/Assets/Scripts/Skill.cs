using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Skill : ScriptableObject
{
    public string skillName;
    public int skillLevel;
    public string skillDescription;
    public int skillDamage;
    public string skillAffect;
    public Sprite skillIcon;
    public int damageType;



}
