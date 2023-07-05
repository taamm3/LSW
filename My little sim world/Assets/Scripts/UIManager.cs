using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerCoinsText;
    [SerializeField] private GameObject _inventoryCanvas;


    private void OnEnable()
    {
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        _playerCoinsText.text = GameManager.Instance.Player.Coins.ToString();
    }

    public void BackClicked()
    {
        GameManager.Instance.Player.SetCanMove(true);
        gameObject.SetActive(false);
    }

    public void OpenShopUI()
    {
        gameObject.SetActive(true);
    }

    public void OpenInventoryUI()
    {
        _inventoryCanvas.SetActive(!_inventoryCanvas.activeInHierarchy);
    }
}
