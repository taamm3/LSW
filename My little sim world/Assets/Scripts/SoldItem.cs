using UnityEngine;

public class SoldItem : MonoBehaviour
{
    [SerializeField] private Outfit outfit;

    public void ButtonClicked()
    {
        if (GameManager.Instance.Player.Coins >= outfit.price)
        {
            GameManager.Instance.Inventory.AddItem(outfit);
            GameManager.Instance.Player.Pay(outfit.price);
            GameManager.Instance.UIManager.UpdateCoins();
        }
    }
}
