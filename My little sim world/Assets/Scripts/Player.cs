using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Rigidbody2D _rigidbody;
    public InputAction enterShopAction;
    public InputAction openInventoryAction;
    public int Coins = 250;
    private bool CanMove = true;
    Vector3 _startScale;
    

    void Start()
    {
        _startScale = transform.localScale;
        SubscribeToEvents();
    }

    void FixedUpdate()
    {
        if (CanMove)
        {
            Move();
        }
    }

    private void OnDestroy()
    {
        UnsubscribeFromEvents();
    }

    private void SubscribeToEvents()
    {
        enterShopAction.Enable();
        enterShopAction.performed += EnterShop;
        openInventoryAction.Enable();
        openInventoryAction.performed += OpenInventory;
    }

    private void UnsubscribeFromEvents()
    {
        enterShopAction.performed -= EnterShop;
        enterShopAction.Disable();
        openInventoryAction.performed -= OpenInventory;
        openInventoryAction.Disable();
    }

    private void EnterShop(InputAction.CallbackContext obj)
    {
        if (GameManager.Instance.Shop.CanEnter())
        {
            SetCanMove(false);
            GameManager.Instance.UIManager.OpenShopUI();
        }
    }

    private void OpenInventory(InputAction.CallbackContext obj)
    {
        if (CanMove)
        {
            GameManager.Instance.UIManager.OpenInventoryUI();
        }
    }

    public void SetCanMove(bool canMove)
    {
        CanMove = canMove;
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
            transform.localScale = new Vector3(-_startScale.x, _startScale.y, _startScale.z);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * _speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * _speed * Time.deltaTime;
            transform.localScale = _startScale;
        }
    }

    public void Pay(int price)
    {
        Coins -= price;
    }
}
