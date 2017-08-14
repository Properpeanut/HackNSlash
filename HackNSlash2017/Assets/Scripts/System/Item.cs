﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    [SerializeField] string itemName;
    [SerializeField] string description;

    [SerializeField] Icon icon;

    //tooltip replacement that compares its stats what you have equipped.

    //effects / buffs


    public string Name {
        get { return itemName; }
        set { itemName = value; }
    }

    public string Description {
        get { return description; }
        set { description = value; }
    }

    public Icon Thumbnail {
        get { return icon; }
        set { icon = value; }
    }
}
