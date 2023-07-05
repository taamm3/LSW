using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _enterText;


    private void OnTriggerEnter2D(Collider2D other)
    {
        _enterText.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _enterText.gameObject.SetActive(false);
    }

    public bool CanEnter()
    {
        return _enterText.gameObject.activeInHierarchy;
    }
}
