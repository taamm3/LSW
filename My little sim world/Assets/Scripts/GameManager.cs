using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Player Player;
    public Shop Shop;
    public UIManager UIManager;
    public Inventory Inventory;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
