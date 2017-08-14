using UnityEngine;

[System.Serializable]
public class MobAttribute : MonoBehaviour {

    [SerializeField] string attributeName;
    [SerializeField] int baseValue;
    [SerializeField] int currentValue;
    //[SerializeField] int maxValue;

    [SerializeField] Icon icon;
    [SerializeField] AttributeType attribute;


    // Do we want them in an enum for faster ref?

    public string AttributeName {
        get { return attributeName; }
        set { attributeName = value; }
    }

    public int BaseAttributeValue {
        get { return baseValue; }
        set { baseValue = value; }
    }


    public int CurrentAttributeValue {
        get { return currentValue; }
        set { currentValue = value; }
    }

    public void BaseAttributeIncrement(int amount) {
        baseValue += amount;
    }

    // Will we need this or just Increase with a negative amount? (+ -10 = -10)
    public void BaseAttributeDecrement(int amount)
    {
        baseValue -= amount;
    }

    public void CurrentAttributeIncrement(int amount)
    {
        currentValue += amount;
    }

    public void CurrentAttributeDecrement(int amount)
    {
        currentValue -= amount;
    }
}

