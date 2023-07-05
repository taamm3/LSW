using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerCoinsText;


    private void OnEnable()
    {
        _playerCoinsText.text = GameManager.Instance.Player.Coins.ToString();
        //Instantiate(GetOutfitByNumber());
    }

    public void BackClicked()
    {
        GameManager.Instance.Player.SetCanMove(true);
        gameObject.SetActive(false);
    }

    internal void OpenUI()
    {
        gameObject.SetActive(true);
    }
}
