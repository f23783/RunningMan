using UnityEngine;

[CreateAssetMenu(fileName = "ShopMenu", menuName = "Scriptable Objects/New Shop Item",order =1)]
public class ShopItemSO1 : ScriptableObject
{
    public string title;
    public string description;
    public int baseCost;
}
