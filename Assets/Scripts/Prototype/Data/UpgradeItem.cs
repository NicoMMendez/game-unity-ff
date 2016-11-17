﻿using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Prototype.Data
{
    public enum WeaponType
    {
        Primary,
        Special,
        Heavy,
        None
    }

    public enum BonusType
    {
        Attack,
        Cargo,
        Defense,
        Speed
    }

    [CreateAssetMenu]
    public class UpgradeItem : ScriptableObject 
    {
        public string ItemID;
        public BonusType ItemBonus;
        public float BonusValue;
        public WeaponType ItemWeapon;
        public float ItemDurability;
        public GameObject ItemPrefab;
    }
}
