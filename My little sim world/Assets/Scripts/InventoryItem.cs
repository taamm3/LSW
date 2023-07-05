using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private int index;

    public void Init(Outfit outfit = null)
    {
        index = outfit.index;
        image.sprite = outfit.icon;
        UpdateCount(outfit.count);
    }

    public void OnSelect()
    {
        GameManager.Instance.Inventory.PutOn(index);
    }

    public void UpdateCount(int count)
    {
        textMeshPro.text = count.ToString();
    }
}
