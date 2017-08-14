using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Mob : MonoBehaviour {

    [SerializeField] string mobName;
    [SerializeField] int currentHealth;
    [SerializeField] int maxHealth;
    [SerializeField] int level;

    [SerializeField] Icon icon;
    [SerializeField] List<Buff> buffs;

    //Array of buffs

    public string Name {
        get { return mobName; }
        set { mobName = value; }
    }

    public int CurrentHealth {
        get { return currentHealth; }
        set {
            if (value < 0)
                currentHealth = 0;
                else if (value > maxHealth)
                    currentHealth = maxHealth;
                else
                    currentHealth = value;
        }
    }

    public int MaxHealth {
        get { return maxHealth; }
        set {
            if (value < 1)
                maxHealth = 1;
            else
                maxHealth = value;
        }
    }

    public int Level {
        get { return level; }
        set {
            if (value < 0)
                level = 0;
            else
                level = value;
        }
    }

    public Icon ThumbNail {
        get { return icon; }
        set { icon = value; }
    }

    public List<Buff> Buffs {
        get { return buffs; }
        set { buffs = value; }
    }

    public void AddBuff(Buff b) {
        buffs.Add(b);
    }
}
