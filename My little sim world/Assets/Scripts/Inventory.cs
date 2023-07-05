using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Outfit> outfits = new List<Outfit>();
    [SerializeField] private Outfit myOutfit;
    [SerializeField] private Transform UIContent;
    [SerializeField] private InventoryItem inventoryItemPrefab;

    private GameObject currOutfit;
    
    private void Start()
    {
        AddItem(myOutfit);
    }

    public void AddItem(Outfit outfit)
    {
        if (!Contains(outfit))
        {
            outfits.Add(outfit);
            outfits[^1].instance = Instantiate(outfit.Clothes, transform);
            SetCurrentOutfit(outfits[^1].instance);
            InventoryItem invItem = Instantiate(inventoryItemPrefab, UIContent);
            invItem.Init(outfit);
            outfits[^1].inventoryItem = invItem;
        }
    }

    private bool Contains(Outfit outfit)
    {
        foreach (Outfit item in outfits)
        {
            if (item.index == outfit.index)
            {
                item.count++;
                item.inventoryItem.UpdateCount(item.count);
                SetCurrentOutfit(item.instance);
                return true;
            }
        }
        return false;
    }

    public void PutOn(int index)
    {
        foreach (Outfit item in outfits)
        {
            if (item.index == index)
            {
                SetCurrentOutfit(item.instance);
                return;
            }
        }
    }

    private void SetCurrentOutfit(GameObject instance)
    {
        if (currOutfit != null)
        {
            currOutfit.SetActive(false);
        }
        currOutfit = instance;
        currOutfit.SetActive(true);
    }
}
