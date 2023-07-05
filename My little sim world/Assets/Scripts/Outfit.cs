using UnityEngine;

[CreateAssetMenu]
public class Outfit : ScriptableObject
{
    public int index;
    public GameObject Clothes;// in assets
    public Sprite icon;
    public int price;
    public int count;
    public GameObject instance;// in scene
    public InventoryItem inventoryItem;
}
